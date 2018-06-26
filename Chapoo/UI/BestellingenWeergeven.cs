using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapoo.Model;
using Chapoo.Logic;

namespace UI
{
    public class BestellingenWeergeven
    {
        public ListView listView1;

        public Control ListViewVullen(List<BestellingOverzicht> bestellingen)
        {     
            //nieuwe listview aanmaken
            listView1 = new ListView();

            //kolommen maken voor de listview
            listView1.Columns.Add("Bestelling ID", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Gerecht", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tafel", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Tijd", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("aantekening", -2, HorizontalAlignment.Left);

            //de listview vullen met gerechten
            foreach(BestellingOverzicht gerecht in bestellingen)
            {
                string[] items = new string[5];
                ListViewItem item;

                items[0] = gerecht.BestellingId.ToString();
                items[1] = gerecht.Gerecht;
                items[2] = gerecht.Tafelnr.ToString();
                items[4] = gerecht.Aantekening;

                item = new ListViewItem(items);
                
                listView1.Items.Add(item);
            }
            return listView1;
        }

        
    }
}
