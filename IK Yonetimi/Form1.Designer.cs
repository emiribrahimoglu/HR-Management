namespace IK_Yonetimi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.basvuranBtn = new System.Windows.Forms.Button();
            this.elemanbulanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basvuranBtn
            // 
            this.basvuranBtn.Location = new System.Drawing.Point(75, 102);
            this.basvuranBtn.Name = "basvuranBtn";
            this.basvuranBtn.Size = new System.Drawing.Size(285, 193);
            this.basvuranBtn.TabIndex = 0;
            this.basvuranBtn.Text = "Başvuru Yap";
            this.basvuranBtn.UseVisualStyleBackColor = true;
            this.basvuranBtn.Click += new System.EventHandler(this.basvuranBtn_Click);
            // 
            // elemanbulanBtn
            // 
            this.elemanbulanBtn.Location = new System.Drawing.Point(432, 102);
            this.elemanbulanBtn.Name = "elemanbulanBtn";
            this.elemanbulanBtn.Size = new System.Drawing.Size(285, 193);
            this.elemanbulanBtn.TabIndex = 1;
            this.elemanbulanBtn.Text = "Eleman Bul";
            this.elemanbulanBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elemanbulanBtn);
            this.Controls.Add(this.basvuranBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button basvuranBtn;
        private System.Windows.Forms.Button elemanbulanBtn;
    }
}

