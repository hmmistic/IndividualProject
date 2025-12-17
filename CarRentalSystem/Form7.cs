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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form2.rentalCars.Count; i++)
            {
                dataGridView1.Rows.Add(
                     Form2.rentalCars[i],
                     Form2.rentalCustomers[i],
                     Form2.rentalDates[i]
                 );
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                string rental = Form2.rentalCars[index];
                for (int i = 0; i < Form2.cars.Count; i++)
                {
                    if (rental.Contains(Form2.cars[i]))
                    {
                        Form2.carAvailable[i] = true;
                        break;
                    }
                }

                Form2.rentalCars.RemoveAt(index);
                Form2.rentalCustomers.RemoveAt(index);
                Form2.rentalDates.RemoveAt(index);
                RefreshGrid();
                MessageBox.Show("Maşın uğurla geri qaytarıldı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bir icarə seçin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
