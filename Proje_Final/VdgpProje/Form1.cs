using MySql.Data.MySqlClient;

namespace VdgpProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string connectionString = "server=localhost;database=computerservice;uid=root;pwd='';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string query = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", textBox2.Text);

            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Giriþ baþarýlý!");
                Form2 form2 = new Form2();
                form2.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
            }

            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Servis Uygulamasý";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}