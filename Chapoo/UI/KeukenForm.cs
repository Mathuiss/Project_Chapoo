using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapoo.Logic;
using Chapoo.Model;

namespace UI
{
    public partial class KeukenForm : Form
    {
        Timer t = new Timer();

        public KeukenForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tijd laten lopen
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //de tijd en datum weergeven
            LBL_klok.Text = DateTime.Now.ToString("HH:mm");
            LBL_datum.Text = DateTime.Now.ToString("dd MMMM yyyy");
            LBL_dag.Text = DateTime.Now.ToString("dddd");
        }

        private void Btn_Keuken_Click(object sender, EventArgs e)
        {
            KeukenUI keukenWeergaven = new KeukenUI();
            keukenWeergaven.ShowDialog();
        }

        private void Btn_bar_Click(object sender, EventArgs e)
        {
            Bar bar = new Bar();
            bar.ShowDialog();
        }
    }
}


