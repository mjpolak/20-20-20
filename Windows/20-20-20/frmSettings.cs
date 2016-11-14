using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_20_20
{
    public partial class frmSettings : Form
    {
        public string Napis
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private Color _kolor;

        public Color Kolor
        {
            get { return _kolor; }
            set
            {
                _kolor = value;
                panel1.BackColor = value;
            }
        }

        private Color _kolorNapisu;

        public Color KolorNapisu
        {
            get { return _kolorNapisu; }
            set
            {
                _kolorNapisu = value;
                panel2.BackColor = value;
            }
        }


        public frmSettings()
        {
            InitializeComponent();
            Napis = Properties.Settings.Default.Napis;
            Kolor = Properties.Settings.Default.KolorTla;
            KolorNapisu = Properties.Settings.Default.KolorNapisu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Kolor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Napis = Napis;
            Properties.Settings.Default.KolorTla = Kolor;
            Properties.Settings.Default.KolorNapisu = KolorNapisu;

            Properties.Settings.Default.Save();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                KolorNapisu = colorDialog2.Color;
            }
        }
    }
}
