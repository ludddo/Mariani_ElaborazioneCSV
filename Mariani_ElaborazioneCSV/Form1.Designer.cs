namespace Mariani_ElaborazioneCSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.closeGroupBox1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeGroupBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(340, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 264);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 193);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // closeGroupBox1
            // 
            this.closeGroupBox1.Location = new System.Drawing.Point(373, 219);
            this.closeGroupBox1.Name = "closeGroupBox1";
            this.closeGroupBox1.Size = new System.Drawing.Size(75, 23);
            this.closeGroupBox1.TabIndex = 1;
            this.closeGroupBox1.Text = "Close";
            this.closeGroupBox1.UseVisualStyleBackColor = true;
            this.closeGroupBox1.Click += new System.EventHandler(this.closeGroupBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.azione3);
            this.Controls.Add(this.azione2);
            this.Controls.Add(this.azione1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button azione1;
        private System.Windows.Forms.Button azione2;
        private System.Windows.Forms.Button azione3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button closeGroupBox1;
    }
}

