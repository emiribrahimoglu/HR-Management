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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // basvuranBtn
            // 
            this.basvuranBtn.Location = new System.Drawing.Point(56, 83);
            this.basvuranBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basvuranBtn.Name = "basvuranBtn";
            this.basvuranBtn.Size = new System.Drawing.Size(214, 157);
            this.basvuranBtn.TabIndex = 0;
            this.basvuranBtn.Text = "Başvuru Yap";
            this.basvuranBtn.UseVisualStyleBackColor = true;
            this.basvuranBtn.Click += new System.EventHandler(this.basvuranBtn_Click);
            // 
            // elemanbulanBtn
            // 
            this.elemanbulanBtn.Location = new System.Drawing.Point(324, 83);
            this.elemanbulanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.elemanbulanBtn.Name = "elemanbulanBtn";
            this.elemanbulanBtn.Size = new System.Drawing.Size(214, 157);
            this.elemanbulanBtn.TabIndex = 1;
            this.elemanbulanBtn.Text = "Eleman Bul";
            this.elemanbulanBtn.UseVisualStyleBackColor = true;
            this.elemanbulanBtn.Click += new System.EventHandler(this.elemanbulanBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tüm Başvuranları Dosyaya Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tüm Başvuranları Dosyadan Oku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.elemanbulanBtn);
            this.Controls.Add(this.basvuranBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button basvuranBtn;
        private System.Windows.Forms.Button elemanbulanBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

