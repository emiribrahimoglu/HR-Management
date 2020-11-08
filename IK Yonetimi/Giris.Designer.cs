namespace IK_Yonetimi
{
    partial class Giris
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
            this.adTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.adLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.uyeolLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(115, 59);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(153, 22);
            this.adTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(115, 138);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(153, 22);
            this.sifreTxt.TabIndex = 0;
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Location = new System.Drawing.Point(27, 59);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(29, 17);
            this.adLbl.TabIndex = 1;
            this.adLbl.Text = "Ad:";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Location = new System.Drawing.Point(27, 141);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(41, 17);
            this.sifreLbl.TabIndex = 1;
            this.sifreLbl.Text = "Şifre:";
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(154, 166);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 31);
            this.girisBtn.TabIndex = 2;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.Location = new System.Drawing.Point(27, 105);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(82, 17);
            this.telefonLbl.TabIndex = 3;
            this.telefonLbl.Text = "Telefon No:";
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(115, 100);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(153, 22);
            this.telTxt.TabIndex = 4;
            // 
            // uyeolLbl
            // 
            this.uyeolLbl.AutoSize = true;
            this.uyeolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeolLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.uyeolLbl.Location = new System.Drawing.Point(126, 200);
            this.uyeolLbl.Name = "uyeolLbl";
            this.uyeolLbl.Size = new System.Drawing.Size(123, 17);
            this.uyeolLbl.TabIndex = 5;
            this.uyeolLbl.Text = "Üye Değil Misiniz?";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.uyeolLbl);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.telefonLbl);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreLbl);
            this.Controls.Add(this.adLbl);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.adTxt);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label uyeolLbl;
    }
}