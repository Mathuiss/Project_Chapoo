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
    public partial class Bar : Form
    {
        KeukenManager logicBar = new KeukenManager();
        private List<BestellingOverzicht> besteldDrinken;

        public Bar()
        {
            InitializeComponent();
        }

        private void Bar_Load(object sender, EventArgs e)
        {
            //timer starten
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //de tijd en datum weergeven
            LBL_klok.Text = DateTime.Now.ToString("HH:mm");
            LBL_datum.Text = DateTime.Now.ToString("dd MMMM yyyy");
            LBL_dag.Text = DateTime.Now.ToString("dddd");

            //iedere zoveel seconden wordt de lijsten opniew geladen
            try
            {
                besteldDrinken = logicBar.GetBestellingDrinken();
                DGV_BesteldDrinken.DataSource = besteldDrinken;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
