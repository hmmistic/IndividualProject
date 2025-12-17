using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < Form2.cars.Count; i++)
            {
                if (Form2.carAvailable[i])
                {
                    comboBox1.Items.Add(Form2.cars[i]);
                }
            }

            comboBox2.Items.Clear();
            for (int i = 0; i < Form2.customers.Count; i++)
            {
                comboBox2.Items.Add(Form2.customers[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && maskedTextBox1.Text != "")
            {
                string selectedCar = comboBox1.SelectedItem.ToString();
                string selectedCustomer = comboBox2.SelectedItem.ToString();
                string days = maskedTextBox1.Text;

                int carIndex = Form2.cars.IndexOf(selectedCar);
                Form2.carAvailable[carIndex] = false;

                int numDays = int.Parse(days);
                decimal rate = decimal.Parse(Form2.carRates[carIndex]);
                decimal total = rate * numDays;

                string rental = selectedCustomer + " adlı müştəri " + selectedCar + " maşınını " + days + " günə icarəyə götürdü - Ümümu məbləğ: $" + total + " - Tarix: " + DateTime.Now.ToString();
                Form2.rentals.Add(rental);

                MessageBox.Show("Avtomobil uğurla icarəyə götürüldü! Ümumi qiymət: ₼" + total, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 mainForm = new Form2();
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
