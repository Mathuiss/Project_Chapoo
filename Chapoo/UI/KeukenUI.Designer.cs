namespace UI
{
    partial class KeukenUI
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
            this.components = new System.ComponentModel.Container();
            this.LV_bestellingen = new System.Windows.Forms.ListView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LBL_dag = new System.Windows.Forms.Label();
            this.LBL_klok = new System.Windows.Forms.Label();
            this.LBL_datum = new System.Windows.Forms.Label();
            this.DGV_Bestellingen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bestellingen)).BeginInit();
            this.SuspendLayout();
            // 
            // LV_bestellingen
            // 
            this.LV_bestellingen.Location = new System.Drawing.Point(1051, 3);
            this.LV_bestellingen.Name = "LV_bestellingen";
            this.LV_bestellingen.Size = new System.Drawing.Size(10, 10);
            this.LV_bestellingen.TabIndex = 0;
            this.LV_bestellingen.UseCompatibleStateImageBehavior = false;
            this.LV_bestellingen.SelectedIndexChanged += new System.EventHandler(this.LV_bestellingen_SelectedIndexChanged);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LBL_dag
            // 
            this.LBL_dag.AutoSize = true;
            this.LBL_dag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dag.Location = new System.Drawing.Point(917, 90);
            this.LBL_dag.Name = "LBL_dag";
            this.LBL_dag.Size = new System.Drawing.Size(94, 25);
            this.LBL_dag.TabIndex = 6;
            this.LBL_dag.Text = "maandag";
            // 
            // LBL_klok
            // 
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(910, 34);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(120, 44);
            this.LBL_klok.TabIndex = 5;
            this.LBL_klok.Text = "00:00";
            // 
            // LBL_datum
            // 
            this.LBL_datum.AutoSize = true;
            this.LBL_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_datum.Location = new System.Drawing.Point(918, 128);
            this.LBL_datum.Name = "LBL_datum";
            this.LBL_datum.Size = new System.Drawing.Size(114, 20);
            this.LBL_datum.TabIndex = 7;
            this.LBL_datum.Text = "1 januari 2000";
            // 
            // DGV_Bestellingen
            // 
            this.DGV_Bestellingen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bestellingen.Location = new System.Drawing.Point(39, 34);
            this.DGV_Bestellingen.Name = "DGV_Bestellingen";
            this.DGV_Bestellingen.RowTemplate.Height = 24;
            this.DGV_Bestellingen.Size = new System.Drawing.Size(835, 497);
            this.DGV_Bestellingen.TabIndex = 8;
            this.DGV_Bestellingen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_bestellingen_CellContentClick);
            // 
            // KeukenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.DGV_Bestellingen);
            this.Controls.Add(this.LBL_datum);
            this.Controls.Add(this.LBL_dag);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.LV_bestellingen);
            this.Name = "KeukenUI";
            this.Text = "Keuken";
            this.Load += new System.EventHandler(this.Keuken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bestellingen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LV_bestellingen;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LBL_dag;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.Label LBL_datum;
        private System.Windows.Forms.DataGridView DGV_Bestellingen;
    }
}