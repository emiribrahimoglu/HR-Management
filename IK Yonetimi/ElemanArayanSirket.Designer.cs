namespace IK_Yonetimi
{
    partial class ElemanArayanSirket
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adagorearaBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mindeneyimTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.belirliyasaltiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ehliyetTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secilenfiltrelerListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filtreekleBtn = new System.Windows.Forms.Button();
            this.filtreleriuygulaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 49);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 303);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 0;
            // 
            // adagorearaBtn
            // 
            this.adagorearaBtn.Location = new System.Drawing.Point(131, 25);
            this.adagorearaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adagorearaBtn.Name = "adagorearaBtn";
            this.adagorearaBtn.Size = new System.Drawing.Size(56, 19);
            this.adagorearaBtn.TabIndex = 1;
            this.adagorearaBtn.Text = "Ara";
            this.adagorearaBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "En az lisans mezunu olanlar",
            "İngilizce bilenler",
            "Birden fazla yabancı dil bilenler",
            "Deneyimsizler"});
            this.comboBox1.Location = new System.Drawing.Point(245, 49);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mindeneyimTxt
            // 
            this.mindeneyimTxt.Location = new System.Drawing.Point(388, 96);
            this.mindeneyimTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mindeneyimTxt.Name = "mindeneyimTxt";
            this.mindeneyimTxt.Size = new System.Drawing.Size(76, 20);
            this.mindeneyimTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Minimum Deneyim (Yıl)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İstenilen Yaşın Altını Seçmek";
            // 
            // belirliyasaltiTxt
            // 
            this.belirliyasaltiTxt.Location = new System.Drawing.Point(388, 119);
            this.belirliyasaltiTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.belirliyasaltiTxt.Name = "belirliyasaltiTxt";
            this.belirliyasaltiTxt.Size = new System.Drawing.Size(76, 20);
            this.belirliyasaltiTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ehliyet Tipi Giriniz";
            // 
            // ehliyetTxt
            // 
            this.ehliyetTxt.Location = new System.Drawing.Point(388, 141);
            this.ehliyetTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ehliyetTxt.Name = "ehliyetTxt";
            this.ehliyetTxt.Size = new System.Drawing.Size(76, 20);
            this.ehliyetTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aramak İstediğiniz Kişinin Adını Giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filtre Seçiniz";
            // 
            // secilenfiltrelerListBox
            // 
            this.secilenfiltrelerListBox.FormattingEnabled = true;
            this.secilenfiltrelerListBox.Location = new System.Drawing.Point(476, 49);
            this.secilenfiltrelerListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secilenfiltrelerListBox.Name = "secilenfiltrelerListBox";
            this.secilenfiltrelerListBox.Size = new System.Drawing.Size(98, 134);
            this.secilenfiltrelerListBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Seçilen Filtreler";
            // 
            // filtreekleBtn
            // 
            this.filtreekleBtn.Location = new System.Drawing.Point(285, 187);
            this.filtreekleBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtreekleBtn.Name = "filtreekleBtn";
            this.filtreekleBtn.Size = new System.Drawing.Size(98, 24);
            this.filtreekleBtn.TabIndex = 7;
            this.filtreekleBtn.Text = "Filtre Ekle";
            this.filtreekleBtn.UseVisualStyleBackColor = true;
            this.filtreekleBtn.Click += new System.EventHandler(this.filtreekleBtn_Click);
            // 
            // filtreleriuygulaBtn
            // 
            this.filtreleriuygulaBtn.Location = new System.Drawing.Point(476, 187);
            this.filtreleriuygulaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtreleriuygulaBtn.Name = "filtreleriuygulaBtn";
            this.filtreleriuygulaBtn.Size = new System.Drawing.Size(97, 24);
            this.filtreleriuygulaBtn.TabIndex = 9;
            this.filtreleriuygulaBtn.Text = "Filtreleri Uygula";
            this.filtreleriuygulaBtn.UseVisualStyleBackColor = true;
            this.filtreleriuygulaBtn.Click += new System.EventHandler(this.filtreleriuygulaBtn_Click);
            // 
            // ElemanArayanSirket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 358);
            this.Controls.Add(this.filtreleriuygulaBtn);
            this.Controls.Add(this.filtreekleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.secilenfiltrelerListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ehliyetTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.belirliyasaltiTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mindeneyimTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.adagorearaBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ElemanArayanSirket";
            this.Text = "ElemanArayanSirket";
            this.Load += new System.EventHandler(this.ElemanArayanSirket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button adagorearaBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox mindeneyimTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox belirliyasaltiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ehliyetTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox secilenfiltrelerListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filtreekleBtn;
        private System.Windows.Forms.Button filtreleriuygulaBtn;
    }
}