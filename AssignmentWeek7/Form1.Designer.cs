namespace AssignmentWeek7
{
    partial class FormQuizPanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMasukkanKalimat = new System.Windows.Forms.Label();
            this.lblMasukkanHuruf = new System.Windows.Forms.Label();
            this.txtBxMasukkanKalimat = new System.Windows.Forms.TextBox();
            this.txtBxMasukkanHuruf = new System.Windows.Forms.TextBox();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.txtBxMenjadi = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblHasilOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMasukkanKalimat
            // 
            this.lblMasukkanKalimat.AutoSize = true;
            this.lblMasukkanKalimat.Location = new System.Drawing.Point(22, 29);
            this.lblMasukkanKalimat.Name = "lblMasukkanKalimat";
            this.lblMasukkanKalimat.Size = new System.Drawing.Size(131, 19);
            this.lblMasukkanKalimat.TabIndex = 0;
            this.lblMasukkanKalimat.Text = "Masukkan Kalimat :";
            // 
            // lblMasukkanHuruf
            // 
            this.lblMasukkanHuruf.AutoSize = true;
            this.lblMasukkanHuruf.Location = new System.Drawing.Point(22, 91);
            this.lblMasukkanHuruf.Name = "lblMasukkanHuruf";
            this.lblMasukkanHuruf.Size = new System.Drawing.Size(118, 19);
            this.lblMasukkanHuruf.TabIndex = 1;
            this.lblMasukkanHuruf.Text = "Masukkan Huruf :";
            // 
            // txtBxMasukkanKalimat
            // 
            this.txtBxMasukkanKalimat.Location = new System.Drawing.Point(155, 29);
            this.txtBxMasukkanKalimat.Name = "txtBxMasukkanKalimat";
            this.txtBxMasukkanKalimat.Size = new System.Drawing.Size(345, 26);
            this.txtBxMasukkanKalimat.TabIndex = 2;
            // 
            // txtBxMasukkanHuruf
            // 
            this.txtBxMasukkanHuruf.Location = new System.Drawing.Point(155, 91);
            this.txtBxMasukkanHuruf.Name = "txtBxMasukkanHuruf";
            this.txtBxMasukkanHuruf.Size = new System.Drawing.Size(100, 26);
            this.txtBxMasukkanHuruf.TabIndex = 3;
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(332, 91);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(62, 19);
            this.lblMenjadi.TabIndex = 4;
            this.lblMenjadi.Text = "Menjadi:";
            // 
            // txtBxMenjadi
            // 
            this.txtBxMenjadi.Location = new System.Drawing.Point(400, 91);
            this.txtBxMenjadi.Name = "txtBxMenjadi";
            this.txtBxMenjadi.Size = new System.Drawing.Size(100, 26);
            this.txtBxMenjadi.TabIndex = 5;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(155, 155);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(345, 23);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(22, 220);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(50, 19);
            this.lblHasil.TabIndex = 7;
            this.lblHasil.Text = "Hasil : ";
            // 
            // lblHasilOutput
            // 
            this.lblHasilOutput.AutoSize = true;
            this.lblHasilOutput.Location = new System.Drawing.Point(151, 220);
            this.lblHasilOutput.Name = "lblHasilOutput";
            this.lblHasilOutput.Size = new System.Drawing.Size(29, 19);
            this.lblHasilOutput.TabIndex = 8;
            this.lblHasilOutput.Text = ".....";
            this.lblHasilOutput.Click += new System.EventHandler(this.lblHasilOutput_Click);
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 280);
            this.Controls.Add(this.lblHasilOutput);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtBxMenjadi);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.txtBxMasukkanHuruf);
            this.Controls.Add(this.txtBxMasukkanKalimat);
            this.Controls.Add(this.lblMasukkanHuruf);
            this.Controls.Add(this.lblMasukkanKalimat);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.Load += new System.EventHandler(this.FormQuizPanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasukkanKalimat;
        private System.Windows.Forms.Label lblMasukkanHuruf;
        private System.Windows.Forms.TextBox txtBxMasukkanKalimat;
        private System.Windows.Forms.TextBox txtBxMasukkanHuruf;
        private System.Windows.Forms.Label lblMenjadi;
        private System.Windows.Forms.TextBox txtBxMenjadi;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblHasilOutput;
    }
}

