namespace _2024_09_05_aknakereso2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.magassag = new System.Windows.Forms.NumericUpDown();
            this.szelesseg = new System.Windows.Forms.NumericUpDown();
            this.mineNumber = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magassag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szelesseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // magassag
            // 
            this.magassag.Location = new System.Drawing.Point(11, 68);
            this.magassag.Name = "magassag";
            this.magassag.Size = new System.Drawing.Size(120, 20);
            this.magassag.TabIndex = 1;
            this.magassag.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // szelesseg
            // 
            this.szelesseg.Location = new System.Drawing.Point(11, 94);
            this.szelesseg.Name = "szelesseg";
            this.szelesseg.Size = new System.Drawing.Size(120, 20);
            this.szelesseg.TabIndex = 2;
            this.szelesseg.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // mineNumber
            // 
            this.mineNumber.Location = new System.Drawing.Point(11, 120);
            this.mineNumber.Name = "mineNumber";
            this.mineNumber.Size = new System.Drawing.Size(120, 20);
            this.mineNumber.TabIndex = 3;
            this.mineNumber.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 39);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Könnyű",
            "Közepes",
            "Nehéz",
            "Bosznia",
            "Egyedi"});
            this.comboBox1.Location = new System.Drawing.Point(11, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nehézség";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Magassag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Szélesség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aknaszám";
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(11, 146);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 10;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mineNumber);
            this.Controls.Add(this.szelesseg);
            this.Controls.Add(this.magassag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Aknakereső (minesweeper úgymond)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magassag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szelesseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mineNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown magassag;
        private System.Windows.Forms.NumericUpDown szelesseg;
        private System.Windows.Forms.NumericUpDown mineNumber;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Restart;
    }
}

