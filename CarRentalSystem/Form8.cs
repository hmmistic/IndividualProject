using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Form2.rentals.Count == 0)
            {
                dataGridView1.Rows.Add("Heç bir akitv icarə yoxdur.");
            }
            else
            {
                for (int i = 0; i < Form2.rentals.Count; i++)
                {
                    dataGridView1.Rows.Add(Form2.rentals[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainForm = new Form2();
            mainForm.Show();
            this.Close();
        }
    }
}
