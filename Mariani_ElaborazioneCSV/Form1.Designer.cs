﻿namespace Mariani_ElaborazioneCSV
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.azione1 = new System.Windows.Forms.Button();
            this.azione2 = new System.Windows.Forms.Button();
            this.azione3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // azione1
            // 
            this.azione1.Location = new System.Drawing.Point(67, 62);
            this.azione1.Name = "azione1";
            this.azione1.Size = new System.Drawing.Size(75, 23);
            this.azione1.TabIndex = 0;
            this.azione1.Text = "Azione1";
            this.azione1.UseVisualStyleBackColor = true;
            this.azione1.Click += new System.EventHandler(this.azione1_Click);
            // 
            // azione2
            // 
            this.azione2.Location = new System.Drawing.Point(167, 62);
            this.azione2.Name = "azione2";
            this.azione2.Size = new System.Drawing.Size(75, 23);
            this.azione2.TabIndex = 1;
            this.azione2.Text = "Azione2";
            this.azione2.UseVisualStyleBackColor = true;
            this.azione2.Click += new System.EventHandler(this.azione2_Click);
            // 
            // azione3
            // 
            this.azione3.Location = new System.Drawing.Point(275, 62);
            this.azione3.Name = "azione3";
            this.azione3.Size = new System.Drawing.Size(75, 23);
            this.azione3.TabIndex = 2;
            this.azione3.Text = "Azione3";
            this.azione3.UseVisualStyleBackColor = true;
            this.azione3.Click += new System.EventHandler(this.azione3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.azione3);
            this.Controls.Add(this.azione2);
            this.Controls.Add(this.azione1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button azione1;
        private System.Windows.Forms.Button azione2;
        private System.Windows.Forms.Button azione3;
    }
}

