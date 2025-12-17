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
            for (int i = 0; i < Form2.rentalCars.Count; i++)
            {
                dataGridView1.Rows.Add(
                    Form2.rentalCars[i],
                    Form2.rentalCustomers[i],
                    Form2.rentalDays[i],
                    Form2.rentalTotals[i],
                    Form2.rentalDates[i]
                );
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
