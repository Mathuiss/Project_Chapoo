namespace UI
{
    partial class Bar
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DGV_BesteldDrinken = new System.Windows.Forms.DataGridView();
            this.LBL_datum = new System.Windows.Forms.Label();
            this.LBL_dag = new System.Windows.Forms.Label();
            this.LBL_klok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BesteldDrinken)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BestellingId";
            this.dataGridViewTextBoxColumn1.HeaderText = "BestellingId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gerecht";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gerecht";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tafelnr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tafelnr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Aantekening";
            this.dataGridViewTextBoxColumn4.HeaderText = "Aantekening";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BestellingId";
            this.dataGridViewTextBoxColumn5.HeaderText = "BestellingId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Gerecht";
            this.dataGridViewTextBoxColumn6.HeaderText = "Gerecht";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Tafelnr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tafelnr";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Aantekening";
            this.dataGridViewTextBoxColumn8.HeaderText = "Aantekening";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DGV_BesteldDrinken
            // 
            this.DGV_BesteldDrinken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BesteldDrinken.Location = new System.Drawing.Point(32, 32);
            this.DGV_BesteldDrinken.Name = "DGV_BesteldDrinken";
            this.DGV_BesteldDrinken.RowTemplate.Height = 24;
            this.DGV_BesteldDrinken.Size = new System.Drawing.Size(835, 497);
            this.DGV_BesteldDrinken.TabIndex = 9;
            // 
            // LBL_datum
            // 
            this.LBL_datum.AutoSize = true;
            this.LBL_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_datum.Location = new System.Drawing.Point(926, 126);
            this.LBL_datum.Name = "LBL_datum";
            this.LBL_datum.Size = new System.Drawing.Size(114, 20);
            this.LBL_datum.TabIndex = 12;
            this.LBL_datum.Text = "1 januari 2000";
            // 
            // LBL_dag
            // 
            this.LBL_dag.AutoSize = true;
            this.LBL_dag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dag.Location = new System.Drawing.Point(925, 88);
            this.LBL_dag.Name = "LBL_dag";
            this.LBL_dag.Size = new System.Drawing.Size(94, 25);
            this.LBL_dag.TabIndex = 11;
            this.LBL_dag.Text = "maandag";
            // 
            // LBL_klok
            // 
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(918, 32);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(120, 44);
            this.LBL_klok.TabIndex = 10;
            this.LBL_klok.Text = "00:00";
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.LBL_datum);
            this.Controls.Add(this.LBL_dag);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.DGV_BesteldDrinken);
            this.Name = "Bar";
            this.Text = "Bar";
            this.Load += new System.EventHandler(this.Bar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BesteldDrinken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridView DGV_BesteldDrinken;
        private System.Windows.Forms.Label LBL_datum;
        private System.Windows.Forms.Label LBL_dag;
        private System.Windows.Forms.Label LBL_klok;
    }
}