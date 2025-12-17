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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form2.cars.Count; i++)
            {
                string status = Form2.carAvailable[i] ? "Mövcuddur" : "Götürülüb";
                dataGridView1.Rows.Add(Form2.cars[i], "₼" + Form2.carRates[i] + "/gün", status);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string car = textBox1.Text.Trim();
            string rate = textBox2.Text.Trim();

            if (car != "" && rate != "")
            {
                Form2.cars.Add(car);
                Form2.carRates.Add(rate);
                Form2.carAvailable.Add(true);
                textBox1.Clear();
                textBox2.Clear();
                RefreshGrid();
                MessageBox.Show("Maşın uğurla əlavə edildi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Form2.cars.RemoveAt(index);
                Form2.carRates.RemoveAt(index);
                Form2.carAvailable.RemoveAt(index);
                RefreshGrid();
                MessageBox.Show("Maşın uğurla silindi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bir maşın seçin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
