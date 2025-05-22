namespace schoolmanagment
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (email == "admin@gmail.com" && password == "Admin1")
            {
                MessageBox.Show("Login Success ! ");
                student obj = new student();
                this.Hide();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success ! ");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
