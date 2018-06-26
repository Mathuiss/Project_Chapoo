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
using Chapoo.Data;

namespace UI
{
    public partial class KeukenUI : Form
    {
        KeukenManager logickeuken = new KeukenManager();
        private List<BestellingOverzicht> bestellingen;        

        public KeukenUI()
        {
            InitializeComponent();
        }

        private void Keuken_Load(object sender, EventArgs e)
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
                bestellingen = logickeuken.GetBestellingen();
                DGV_Bestellingen.DataSource = bestellingen;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LV_bestellingen_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void DGV_bestellingen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
