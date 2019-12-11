using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_flashScreen : Form
    {
        int a = 0;
        public frm_flashScreen()
        {
            InitializeComponent();
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 220)
            {
                panelSlide.Left = 0;
            }
            a += 10;
            if (a == 3000)
            {
                timerShow.Stop();
                this.Close();
            }
        }

        private void frm_FlashScreen_Load(object sender, EventArgs e)
        {
            timerShow.Start();
        }
    }
}
