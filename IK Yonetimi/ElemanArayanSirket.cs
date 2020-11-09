using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Yonetimi
{
    public partial class ElemanArayanSirket : Form
    {
        public ElemanArayanSirket()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //uygulamak istediğimiz filtreler listboxta tutuldu. 
        //buradan alınarak filtreleri uygulama işleminde kullanılacaklar.
        private void filtreekleBtn_Click(object sender, EventArgs e)
        {
            secilenfiltrelerListBox.Items.Add(comboBox1.SelectedItem);
            secilenfiltrelerListBox.Items.Add(mindeneyimTxt.Text);
            secilenfiltrelerListBox.Items.Add(belirliyasaltiTxt.Text);
            secilenfiltrelerListBox.Items.Add(ehliyetTxt.Text);
        }

        
        private void filtreleriuygulaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
