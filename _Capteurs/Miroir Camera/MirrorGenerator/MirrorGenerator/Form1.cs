using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearRegression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirrorGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nbPoints = Convert.ToInt32(textBoxNbPoints.Text);
            double distanceMiroirCamera = Convert.ToDouble(textBoxDistanceCameraMiroir.Text.Replace(".", ","));
            double hauteurMiroirSol = Convert.ToDouble(textBoxHauteurMiroirSol.Text);
            double diametreMiroir = Convert.ToDouble(textBoxDiametreMiroir.Text);
            double distanceMinVision = Convert.ToDouble(textBoxDistanceMinVision.Text);
            double distanceMaxVision = Convert.ToDouble(textBoxDistanceMaxVision.Text);
            double rayonMiroir = Convert.ToDouble(textBoxDiametreMiroir.Text) / 2.0;
            int ordrePolynome = Convert.ToInt32(textBoxOrdrePolynome.Text);

            double AngleCameraMax = Math.Atan2(rayonMiroir, distanceMiroirCamera);

            double[] ApproximationElevationMiroir = new double[nbPoints + 1];
            double[] angleCameraCourant = new double[nbPoints + 1];
            double[] rMiroirCourant = new double[nbPoints + 1];
            double[] alpha = new double[nbPoints + 1];
            double[] theta = new double[nbPoints + 1];
            double[] gamma = new double[nbPoints + 1];
            double[] xCibleCourant = new double[nbPoints + 1];
            double[] inclinaison = new double[nbPoints + 1];



            //Initialisation de la forme du miroir
            for (int i = 0; i < nbPoints + 1; i++)
            {
                ApproximationElevationMiroir[i] = 0;
            }

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < nbPoints + 1; i++)
                {
                    double percentage = (double)(i) / nbPoints;

                    ////Prise en compte de l'angle
                    //angleCameraCourant[i] = percentage * AngleCameraMax;
                    //rMiroirCourant[i] = distanceMiroirCamera * Math.Tan(angleCameraCourant[i]);

                    //Sans prise en compte de l'angle
                    rMiroirCourant[i] = percentage * rayonMiroir;

                    alpha[i] = Math.Atan2(distanceMiroirCamera + ApproximationElevationMiroir[i], rMiroirCourant[i]);

                    xCibleCourant[i] = distanceMinVision + percentage * (distanceMaxVision - distanceMinVision);
                    theta[i] = Math.Atan2(hauteurMiroirSol + ApproximationElevationMiroir[i], xCibleCourant[i] - rMiroirCourant[i]);

                    gamma[i] = (Math.PI - theta[i] - alpha[i]);
                    inclinaison[i] = alpha[i] + gamma[i]/2 - Math.PI / 2;

                    if (i > 0)
                        ApproximationElevationMiroir[i] = rayonMiroir / nbPoints * Math.Tan((inclinaison[i] + inclinaison[i - 1]) / 2.0) + ApproximationElevationMiroir[i - 1];
                }
            }



            string output = "";

            //Affichage des points de la courbe
            for (int i = 0; i < nbPoints + 1; i++)
            {
                output += rMiroirCourant[i].ToString("N3") + " " + ApproximationElevationMiroir[i].ToString("N3")+"\n";
            }

            //Affichage du polynome
            var polynom = Polynomial(rMiroirCourant, ApproximationElevationMiroir, ordrePolynome);
            
            string equation = "Equation du miroir : \n";

            for(int i= ordrePolynome; i>=0; i--)
            {
                equation += polynom[i].ToString("N20") + "*x^(" + i.ToString() + ")";
                if (i != 0)
                    equation += " + ";
            }
            equation += "\n\n";
            output = equation + output;
            output = output.Replace(',', '.');

            richTextBoxResultat.Text = output;

        }

        public static double[] Polynomial(double[] x, double[] y, int order)
        {
            var design = Matrix<double>.Build.Dense(x.Length, order + 1, (i, j) => Math.Pow(x[i], j));
            return MultipleRegression.QR(design, Vector<double>.Build.Dense(y)).ToArray();
        }
    }
}
