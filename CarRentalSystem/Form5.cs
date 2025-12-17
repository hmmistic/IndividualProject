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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Form2.customers.Count; i++)
            {
                dataGridView1.Rows.Add(Form2.customers[i], Form2.customerPhones[i]);
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            if (name != "" && phone != "")
            {
                Form2.customers.Add(name);
                Form2.customerPhones.Add(phone);
                textBox1.Clear();
                textBox2.Clear();
                RefreshList();
                MessageBox.Show("Müştəri uğurla əlavə edildi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Form2.customers.RemoveAt(index);
                Form2.customerPhones.RemoveAt(index);
                RefreshList();
                MessageBox.Show("Müştəri uğurla silindi!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bir müştəri seçin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
