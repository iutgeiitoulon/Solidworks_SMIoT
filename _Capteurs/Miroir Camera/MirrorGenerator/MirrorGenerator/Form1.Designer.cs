namespace MirrorGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNbPoints = new System.Windows.Forms.TextBox();
            this.textBoxHauteurMiroirSol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDiametreMiroir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDistanceMaxVision = new System.Windows.Forms.TextBox();
            this.labelDistanceMaxVision = new System.Windows.Forms.Label();
            this.textBoxDistanceMinVision = new System.Windows.Forms.TextBox();
            this.labelDistanceMinVision = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxResultat = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDistanceCameraMiroir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOrdrePolynome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nb de Points";
            // 
            // textBoxNbPoints
            // 
            this.textBoxNbPoints.Location = new System.Drawing.Point(140, 17);
            this.textBoxNbPoints.Name = "textBoxNbPoints";
            this.textBoxNbPoints.Size = new System.Drawing.Size(79, 20);
            this.textBoxNbPoints.TabIndex = 1;
            this.textBoxNbPoints.Text = "1000";
            // 
            // textBoxHauteurMiroirSol
            // 
            this.textBoxHauteurMiroirSol.Location = new System.Drawing.Point(140, 43);
            this.textBoxHauteurMiroirSol.Name = "textBoxHauteurMiroirSol";
            this.textBoxHauteurMiroirSol.Size = new System.Drawing.Size(79, 20);
            this.textBoxHauteurMiroirSol.TabIndex = 3;
            this.textBoxHauteurMiroirSol.Text = "750";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hauteur Miroir - Sol";
            // 
            // textBoxDiametreMiroir
            // 
            this.textBoxDiametreMiroir.Location = new System.Drawing.Point(140, 69);
            this.textBoxDiametreMiroir.Name = "textBoxDiametreMiroir";
            this.textBoxDiametreMiroir.Size = new System.Drawing.Size(79, 20);
            this.textBoxDiametreMiroir.TabIndex = 5;
            this.textBoxDiametreMiroir.Text = "74";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diametre Miroir";
            // 
            // textBoxDistanceMaxVision
            // 
            this.textBoxDistanceMaxVision.Location = new System.Drawing.Point(140, 98);
            this.textBoxDistanceMaxVision.Name = "textBoxDistanceMaxVision";
            this.textBoxDistanceMaxVision.Size = new System.Drawing.Size(79, 20);
            this.textBoxDistanceMaxVision.TabIndex = 7;
            this.textBoxDistanceMaxVision.Text = "6000";
            // 
            // labelDistanceMaxVision
            // 
            this.labelDistanceMaxVision.AutoSize = true;
            this.labelDistanceMaxVision.Location = new System.Drawing.Point(12, 105);
            this.labelDistanceMaxVision.Name = "labelDistanceMaxVision";
            this.labelDistanceMaxVision.Size = new System.Drawing.Size(117, 13);
            this.labelDistanceMaxVision.TabIndex = 6;
            this.labelDistanceMaxVision.Text = "Distance Max de vision";
            // 
            // textBoxDistanceMinVision
            // 
            this.textBoxDistanceMinVision.Location = new System.Drawing.Point(140, 126);
            this.textBoxDistanceMinVision.Name = "textBoxDistanceMinVision";
            this.textBoxDistanceMinVision.Size = new System.Drawing.Size(79, 20);
            this.textBoxDistanceMinVision.TabIndex = 9;
            this.textBoxDistanceMinVision.Text = "0";
            // 
            // labelDistanceMinVision
            // 
            this.labelDistanceMinVision.AutoSize = true;
            this.labelDistanceMinVision.Location = new System.Drawing.Point(12, 133);
            this.labelDistanceMinVision.Name = "labelDistanceMinVision";
            this.labelDistanceMinVision.Size = new System.Drawing.Size(114, 13);
            this.labelDistanceMinVision.TabIndex = 8;
            this.labelDistanceMinVision.Text = "Distance Min de vision";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculer le Miroir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxResultat
            // 
            this.richTextBoxResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResultat.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxResultat.Name = "richTextBoxResultat";
            this.richTextBoxResultat.Size = new System.Drawing.Size(557, 403);
            this.richTextBoxResultat.TabIndex = 11;
            this.richTextBoxResultat.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxResultat);
            this.groupBox1.Location = new System.Drawing.Point(244, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 422);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résultat";
            // 
            // textBoxDistanceCameraMiroir
            // 
            this.textBoxDistanceCameraMiroir.Location = new System.Drawing.Point(140, 155);
            this.textBoxDistanceCameraMiroir.Name = "textBoxDistanceCameraMiroir";
            this.textBoxDistanceCameraMiroir.Size = new System.Drawing.Size(79, 20);
            this.textBoxDistanceCameraMiroir.TabIndex = 14;
            this.textBoxDistanceCameraMiroir.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Distance Camera Miroir";
            // 
            // textBoxOrdrePolynome
            // 
            this.textBoxOrdrePolynome.Location = new System.Drawing.Point(140, 183);
            this.textBoxOrdrePolynome.Name = "textBoxOrdrePolynome";
            this.textBoxOrdrePolynome.Size = new System.Drawing.Size(79, 20);
            this.textBoxOrdrePolynome.TabIndex = 16;
            this.textBoxOrdrePolynome.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ordre du polynome ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 451);
            this.Controls.Add(this.textBoxOrdrePolynome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDistanceCameraMiroir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDistanceMinVision);
            this.Controls.Add(this.labelDistanceMinVision);
            this.Controls.Add(this.textBoxDistanceMaxVision);
            this.Controls.Add(this.labelDistanceMaxVision);
            this.Controls.Add(this.textBoxDiametreMiroir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHauteurMiroirSol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNbPoints);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculateur de Miroir";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNbPoints;
        private System.Windows.Forms.TextBox textBoxHauteurMiroirSol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiametreMiroir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDistanceMaxVision;
        private System.Windows.Forms.Label labelDistanceMaxVision;
        private System.Windows.Forms.TextBox textBoxDistanceMinVision;
        private System.Windows.Forms.Label labelDistanceMinVision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxResultat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDistanceCameraMiroir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOrdrePolynome;
        private System.Windows.Forms.Label label5;
    }
}

