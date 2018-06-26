namespace UI
{
    partial class KeukenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeukenForm));
            this.Btn_bar = new System.Windows.Forms.Button();
            this.Btn_Keuken = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LBL_klok = new System.Windows.Forms.Label();
            this.LBL_datum = new System.Windows.Forms.Label();
            this.LBL_dag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_bar
            // 
            this.Btn_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Btn_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_bar.Location = new System.Drawing.Point(298, 402);
            this.Btn_bar.Name = "Btn_bar";
            this.Btn_bar.Size = new System.Drawing.Size(170, 71);
            this.Btn_bar.TabIndex = 0;
            this.Btn_bar.Text = "Bar";
            this.Btn_bar.UseVisualStyleBackColor = false;
            this.Btn_bar.Click += new System.EventHandler(this.Btn_bar_Click);
            // 
            // Btn_Keuken
            // 
            this.Btn_Keuken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_Keuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Keuken.Location = new System.Drawing.Point(613, 402);
            this.Btn_Keuken.Name = "Btn_Keuken";
            this.Btn_Keuken.Size = new System.Drawing.Size(170, 71);
            this.Btn_Keuken.TabIndex = 1;
            this.Btn_Keuken.Text = "Keuken";
            this.Btn_Keuken.UseVisualStyleBackColor = false;
            this.Btn_Keuken.Click += new System.EventHandler(this.Btn_Keuken_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LBL_klok
            // 
            this.LBL_klok.AutoSize = true;
            this.LBL_klok.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_klok.Location = new System.Drawing.Point(469, 489);
            this.LBL_klok.Name = "LBL_klok";
            this.LBL_klok.Size = new System.Drawing.Size(120, 44);
            this.LBL_klok.TabIndex = 2;
            this.LBL_klok.Text = "00:00";
            // 
            // LBL_datum
            // 
            this.LBL_datum.AutoSize = true;
            this.LBL_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_datum.Location = new System.Drawing.Point(473, 580);
            this.LBL_datum.Name = "LBL_datum";
            this.LBL_datum.Size = new System.Drawing.Size(114, 20);
            this.LBL_datum.TabIndex = 3;
            this.LBL_datum.Text = "1 januari 2000";
            // 
            // LBL_dag
            // 
            this.LBL_dag.AutoSize = true;
            this.LBL_dag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dag.Location = new System.Drawing.Point(472, 543);
            this.LBL_dag.Name = "LBL_dag";
            this.LBL_dag.Size = new System.Drawing.Size(94, 25);
            this.LBL_dag.TabIndex = 4;
            this.LBL_dag.Text = "maandag";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // KeukenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_dag);
            this.Controls.Add(this.LBL_datum);
            this.Controls.Add(this.LBL_klok);
            this.Controls.Add(this.Btn_Keuken);
            this.Controls.Add(this.Btn_bar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeukenForm";
            this.Text = "Keuken";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_bar;
        private System.Windows.Forms.Button Btn_Keuken;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LBL_klok;
        private System.Windows.Forms.Label LBL_datum;
        private System.Windows.Forms.Label LBL_dag;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

