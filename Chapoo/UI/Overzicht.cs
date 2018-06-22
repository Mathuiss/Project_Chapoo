using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapoo.Logic;
using Chapoo.Model;
using System.Windows.Forms;

namespace UI
{
    public class Overzicht : KeukenForm
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Name = "Overzicht";
            this.Load += new System.EventHandler(this.Overzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Overzicht_Load(object sender, EventArgs e)
        {

        }
    }
}
