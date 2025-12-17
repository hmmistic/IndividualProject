namespace CarRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            usernames[0] = "admin";
            passwords[0] = "12345678";
            userCount = 1;
        }

        public static string[] usernames = new string[100];
        public static string[] passwords = new string[100];
        public static int userCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Zəhmət olmasa istifadəçi adını daxil edin");
                if (textBox2.Text != "") errorProvider2.Clear();
            }

            if (textBox2.Text == "")
            {
                errorProvider2.SetError(textBox2, "Zəhmət olmasa şifrəni daxil edin");
                if (textBox1.Text != "") errorProvider1.Clear();
            }

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                errorProvider1.Clear();
                errorProvider2.Clear();

                bool isFound = false;
                for (int i = 0; i < userCount; i++)
                {
                    if (textBox1.Text == usernames[i] && textBox2.Text == passwords[i])
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    Form2 mainForm = new Form2();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı, yaxud şifrə səhvdir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 signupForm = new Form3();
            signupForm.Show();
            this.Hide();
        }
    }
}
