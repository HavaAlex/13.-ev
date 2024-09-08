using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_09_05_aknakereso2
{
    public partial class Form1 : Form
    {
        static List<List<bool>> bombak;
        public Form1()
        {
            InitializeComponent();
            alaphelyzet(comboBox1, magassag, szelesseg, mineNumber, label1, label2, label3, dataGridView1, Restart);
            

        }
        static void alaphelyzet(ComboBox comboBox1, NumericUpDown magassag, NumericUpDown szelesseg, NumericUpDown mineNumber, System.Windows.Forms.Label label1, System.Windows.Forms.Label label2, System.Windows.Forms.Label label3, DataGridView dataGridView1, Button Restart)
        {
            comboBox1.SelectedIndex = 1;
            customelrejt(magassag, szelesseg, mineNumber, label1, label2, label3);
            magassag.Minimum = 5;
            magassag.Maximum = 25;
            magassag.Value = 10;
            szelesseg.Minimum = 5;
            szelesseg.Maximum = 25;
            szelesseg.Value = 10;
            mineNumber.Minimum = 1;
            mineNumber.Maximum = (magassag.Value * szelesseg.Value) - 1;
            mineNumber.Value = 10;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            atmeretezes(dataGridView1);
            bombak = new List<List<bool>>();
            dataGridView1.MouseMove += egerjonmegy;
            dataGridView1.Enabled = true;
            Restart.Visible = false;
            
        }
        
        static void egerjonmegy(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
        }
        static void customelrejt(NumericUpDown m, NumericUpDown sz, NumericUpDown db, System.Windows.Forms.Label elso, System.Windows.Forms.Label masodik, System.Windows.Forms.Label haromadik)
        {
            m.Visible = false;
            sz.Visible = false;
            db.Visible = false;
            elso.Visible = false;
            masodik.Visible = false;
            haromadik.Visible = false;
        }
        static void custommegjelenik(NumericUpDown m, NumericUpDown sz, NumericUpDown db, System.Windows.Forms.Label elso, System.Windows.Forms.Label masodik, System.Windows.Forms.Label haromadik)
        {
            m.Visible = true;
            sz.Visible = true;
            db.Visible = true;
            elso.Visible = true;
            masodik.Visible = true;
            haromadik.Visible = true;
        }
        static void atmeretezes(DataGridView t)
        {
            for (int i = 0; i < t.Columns.Count; i++)
            {
                t.Columns[i].Width = 40;
            }
            for (int i = 0;i < t.Rows.Count; i++)
            {
                t.Rows[i].Height = 40;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(mineNumber.Value > (magassag.Value * szelesseg.Value) - 1)
            {
                mineNumber.Value = ((magassag.Value * szelesseg.Value));
            }
            mineNumber.Maximum = (magassag.Value * szelesseg.Value) - 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (mineNumber.Value > (magassag.Value * szelesseg.Value) - 1)
            {
                mineNumber.Value = ((magassag.Value * szelesseg.Value));
            }
            mineNumber.Maximum = (magassag.Value * szelesseg.Value) - 1;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            mineNumber.Maximum = (magassag.Value * szelesseg.Value) - 1;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            bombak.Clear();
            dataGridView1.RowCount = Convert.ToInt32(magassag.Value);
            dataGridView1.ColumnCount = Convert.ToInt32(szelesseg.Value);
            atmeretezes(dataGridView1);
            palyacsinalas(magassag, szelesseg, mineNumber);
            for (int i = 0; i < szelesseg.Value; i++)
            {
                for (int j = 0; j < magassag.Value; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = "?";
                }
            }
            Start.Visible = false;
            Restart.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != 4)
            {
                customelrejt(magassag, szelesseg, mineNumber, label1, label2, label3);
            }
            if (comboBox1.SelectedIndex == 0) 
            {
                magassag.Value = 10;
                szelesseg.Value = 10;
                mineNumber.Value = 5;
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                magassag.Value = 10;
                szelesseg.Value = 10;
                mineNumber.Value = 10;
               
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                magassag.Value = 10;
                szelesseg.Value = 10;
                mineNumber.Value = 25;
                
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                magassag.Value = 10;
                szelesseg.Value = 10;
                mineNumber.Value = 75;
               
            }
            else
            {
                custommegjelenik(magassag, szelesseg, mineNumber, label1, label2, label3);
            }
        }
        static void palyacsinalas(NumericUpDown m, NumericUpDown sz, NumericUpDown db)
        {
            for (int i = 0; i < sz.Value; i++)
            {
                List<bool> sl = new List<bool>();
                for (int j = 0; j < m.Value; j++)
                {
                    bool sb = false;
                    sl.Add(sb);
                }
                bombak.Add(sl);
            }
            Random r = new Random();
            aknak(Convert.ToInt32(m.Value), Convert.ToInt32(sz.Value), Convert.ToInt32(db.Value),r );
        }
        static void aknak(int m, int sz, int db, Random r)
        {
            
            int k = db;
            if (k == 0)
            {

            }
            else
            {
                int x = r.Next(0, sz );
                int y = r.Next(0, m );
                if (!bombak[x][y])
                {
                    bombak[x][y] = true;
                    k--;
                    aknak(m, sz, k,r);
                }
                else 
                { 
                    aknak(m, sz, k, r);
                }
            }
        }
        public static bool bombavanmellete(int x, int y, out int találtTrueSzám)
        {
            
            int[][] directions = new int[][]
            {
            new int[] {-1, -1}, 
            new int[] {0, -1},  
            new int[] {1, -1},  
            new int[] {-1, 0},  
            new int[] {1, 0},   
            new int[] {-1, 1},  
            new int[] {0, 1},   
            new int[] {1, 1}    
            };
            int rows = bombak.Count;
            int cols = bombak[0].Count;
            int trueCount = 0;
            foreach (var dir in directions)
            {
                int newX = x + dir[0];
                int newY = y + dir[1];
                if (newX >= 0 && newX < cols && newY >= 0 && newY < rows)
                {
                    if (bombak[newY][newX])
                    {
                        trueCount++;
                    }
                }
            }
            találtTrueSzám = trueCount;
            return trueCount > 0;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            wincheck(dataGridView1, Convert.ToInt32(mineNumber.Value));
            int szomszedosc4 = 0;
            if (!bombak[e.RowIndex][e.ColumnIndex] && bombavanmellete(e.ColumnIndex, e.RowIndex,out szomszedosc4))
            {

                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Convert.ToString(szomszedosc4);
            }
            else if (!bombak[e.RowIndex][e.ColumnIndex])
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "bomba";
                MessageBox.Show("Felrobbantál xd");
                dataGridView1.Enabled = false;
            }
        }
        static void wincheck(DataGridView dataGridView1, int db)
        {
            int maradekcellaszam = 0;
            for (int i = 0; i < bombak.Count; i++){
                for (int j = 0; j < bombak[i].Count; j++)
                {
                    if(dataGridView1.Rows[j].Cells[i].Value ==  "?")
                    {
                        maradekcellaszam++;
                    }
                }
            }
            if(maradekcellaszam-1 ==db)
            {
                dataGridView1.Enabled = false;
                MessageBox.Show("Gratula győztél");
            }
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Start_Click(sender, e);
            alaphelyzet(comboBox1, magassag, szelesseg, mineNumber, label1, label2, label3, dataGridView1, Restart);
            Start.Visible = true;
            
        }
    }
}
