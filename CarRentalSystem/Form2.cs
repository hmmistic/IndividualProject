using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CarRentalSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static List<string> cars = new List<string> { "Toyota Prius - ABC123", "Honda Civic - XYZ789", "Ford Mustang - DEF456" };
        public static List<string> carRates = new List<string> { "50", "45", "80" };
        public static List<bool> carAvailable = new List<bool> { true, false, true };

        public static List<string> customers = new List<string> { "John Smith", "Jane Doe" };
        public static List<string> customerPhones = new List<string> { "555-0100", "555-0200" };

        public static List<string> rentals = new List<string>();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 carsForm = new Form4();
            carsForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 customersForm = new Form5();
            customersForm.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 rentForm = new Form6();
            rentForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form7 returnForm = new Form7();
            returnForm.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form8 viewForm = new Form8();
            viewForm.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
