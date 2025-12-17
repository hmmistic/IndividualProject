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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Zəhmət olmasa istifadəçi adını daxil edin");
                if (textBox2.Text != "") errorProvider2.Clear();
                if (textBox3.Text != "") errorProvider3.Clear();
            }

            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Zəhmət olmasa şifrəni daxil edin");
                if (textBox1.Text != "") errorProvider1.Clear();
                if (textBox3.Text != "") errorProvider3.Clear();
            }

            if (textBox3.Text == "")
            {
                errorProvider3.SetError(textBox3, "Zəhmət olmasa şifrəni yenidən daxil edin");
                if (textBox1.Text != "") errorProvider1.Clear();
                if (textBox2.Text != "") errorProvider2.Clear();
            }

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();

                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Şifrələr uyğun gəlmir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool exists = false;
                for (int i = 0; i < Form1.userCount; i++)
                {
                    if (textBox1.Text == Form1.usernames[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (exists)
                {
                    MessageBox.Show("Bu istifadəçi adından artıq qeydiyyatdan keçilib!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form1.usernames[Form1.userCount] = textBox1.Text;
                    Form1.passwords[Form1.userCount] = textBox2.Text;
                    Form1.userCount++;

                    MessageBox.Show("Hesab uğurla yaradıldı!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
