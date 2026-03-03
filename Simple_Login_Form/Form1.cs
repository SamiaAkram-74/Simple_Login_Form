namespace Simple_Login_Form
{
    public partial class Form1 : Form
    {
        // Arrays of usernames and passwords
        string[] usernames = { "samia", "urwa", "zainab", "aima", "ruquaya" };
        string[] passwords = { "1234", "5678", "abcd", "efgh", "ijkl" };

        //string username = "samia";
        //string password = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool loginSuccess = false;
            for (int i = 0; i <usernames.Length; i++)
            {
                if (textBox1.Text.ToLower().Equals(usernames[i].ToLower()) && textBox2.Text.Equals(passwords[i]))
                {
                    loginSuccess = true;
                    break; // Exit the loop if a match is found
                }
            }
            if (loginSuccess)
            {
                Form frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Error");
            }
            //if (textBox1.Text.ToLower().Equals(username.ToLower()) && textBox2.Text.Equals(password))
            //{
            //    Form frm = new Form2();
            //    frm.Show();
            //    this.Hide();  // It hides the current form from the screen(form1 here)
            //    //MessageBox.Show("Login Success", "info", MessageBoxButtons.OK);  this code is for form1 where when we login this message display
            //}
            //else
            //{
            //    MessageBox.Show("Login Error");
            //}
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
