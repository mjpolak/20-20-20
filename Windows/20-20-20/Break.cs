using _20_20_20.Properties;
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
    public partial class Break : Form
    {
        public delegate void PauseEndHandler();
        public event PauseEndHandler OnPauseEnd;

        public bool AllowClose = false;
        public Break()
        {
            InitializeComponent();
            label1.Text = "WTF";
            //label1.Text = Properties.Settings.Default.Napis;
            //label1.ForeColor = Properties.Settings.Default.KolorNapisu;
            //BackColor = Properties.Settings.Default.KolorTla;
        }

        private void Break_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AllowClose;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Break_Load(object sender, EventArgs e)
        {

        }

        private void Break_Shown(object sender, EventArgs e)
        {
        }

        private void Break_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Break_Activated(object sender, EventArgs e)
        {
            
            label1.Text = Properties.Settings.Default.Napis;
            label1.ForeColor = Properties.Settings.Default.KolorNapisu;
            BackColor = Properties.Settings.Default.KolorTla;
        }
        public void UpdateCounter(int val)
        {
            if( val > 0 )
            {
                counter.Text = "Pozostało: " + val;
                
            }
            else
            {
                counter.Text = "Przycisnij dowolny klawisz";
            }
        }

        private void Break_KeyDown(object sender, KeyEventArgs e)
        {
            if (OnPauseEnd!=null)
                OnPauseEnd();
        }
    }
}
