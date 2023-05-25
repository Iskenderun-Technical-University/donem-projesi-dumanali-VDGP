using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VdgpProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {


            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            buttonGuncelle.Click += buttonGuncelle_Click;
            textAd.TextChanged += textAd_TextChanged;
            comboBoxMarkasi.SelectedIndexChanged += comboBoxMarkasi_SelectedIndexChanged;
            comboBoxArizasi.SelectedIndexChanged += comboBoxModeli_SelectedIndexChanged;
            comboBoxMarkasi.SelectedIndexChanged += comboBoxArizasi_SelectedIndexChanged;
            comboBoxMarkasi.Items.Add("HP");
            comboBoxMarkasi.Items.Add("Lenovo");
            comboBoxMarkasi.Items.Add("Dell");
            comboBoxArizasi.Items.Add("Sıvı teması");
            comboBoxArizasi.Items.Add("Termal macun yenileme");
            comboBoxArizasi.Items.Add("Anakart arızası");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {


            try
            {
                string connectionString = "server=localhost;database=computerservice;uid=root;password='';";
                string insertSql = "INSERT INTO musteriliste (musteriadi, musterisoyadi , telefon_num , email , markasi , modeli , arizasi , arizadetay) VALUES (@value1, @value2 , @value3 , @value4 , @value5 , @value6 , @value7 ,@value8);";
                string selectedValue = comboBoxMarkasi.SelectedItem.ToString();
                string selectedValue2 = comboBoxModeli.SelectedItem.ToString();
                string selectedValue3 = comboBoxArizasi.SelectedItem.ToString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(insertSql, connection))
                    {
                        string input = textAd.Text;
                        string input2 = textSoyad.Text;

                        if (!Regex.IsMatch(input, "^[a-zA-Z]+$") || !Regex.IsMatch(input2, "^[a-zA-Z]+$"))
                        {
                            MessageBox.Show("Ad, Soyad sadece harflerden oluşmalıdır");
                            return;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@value1", textAd.Text);
                            command.Parameters.AddWithValue("@value2", textSoyad.Text);
                            command.Parameters.AddWithValue("@value3", textTelefon.Text);
                            command.Parameters.AddWithValue("@value4", textEmail.Text);
                            command.Parameters.AddWithValue("@value5", selectedValue);
                            command.Parameters.AddWithValue("@value6", selectedValue2);
                            command.Parameters.AddWithValue("@value7", selectedValue3);
                            command.Parameters.AddWithValue("@value8", richTextBoxArızaDetay.Text);
                            command.ExecuteNonQuery();

                            MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from musteriliste", connection);
                            DataTable dtbl = new DataTable();
                            sqDa.Fill(dtbl);
                            dataGridView1.DataSource = dtbl;

                        }

                    }
                }

                MessageBox.Show("Veri ekleme başarılı!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veriler Hatalı girildi!" + MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string textBox1Value = textAd.Text;
                string textBox2Value = textSoyad.Text;
                string textBox3Value = textTelefon.Text;
                string textBox4Value = textEmail.Text;


                foreach (DataGridViewRow row in selectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["id"].Value);
                    string query = $"UPDATE musteriliste SET musteriadi = @musteriadi, musterisoyadi = @musterisoyadi , telefon_num = @telefon_num , email =@email WHERE id = {id}";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@musteriadi", textBox1Value);
                    command.Parameters.AddWithValue("@musterisoyadi", textBox2Value);
                    command.Parameters.AddWithValue("@telefon_num", textBox3Value);
                    command.Parameters.AddWithValue("@email", textBox4Value);

                    int rowsUpdated = command.ExecuteNonQuery();

                    MessageBox.Show("Güncelleme Başarılı!");

                    if (rowsUpdated > 0)
                    {

                        MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from musteriliste", connection);
                        DataTable dtbl = new DataTable();
                        sqDa.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                }
            }
        }
        private void buttonSil_Click(object sender, EventArgs e)
        {


            try
            {
                DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;


                string connectionString = "server=localhost;database=computerservice;uid=root;password='';";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();


                    foreach (DataGridViewRow row in selectedRows)
                    {

                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string query = $"DELETE FROM musteriliste WHERE id = {id}";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Silme işlemi başarılı!");

                        MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from musteriliste", connection);
                        DataTable dtbl = new DataTable();
                        sqDa.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Silme işlemi başarısız!" + ex.Message);

            }

        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter sqDa = new MySqlDataAdapter("Select * from musteriliste", connection);
                DataTable dtbl = new DataTable();
                sqDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void comboBoxMarkasi_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxModeli.Items.Clear();
            string selectedItem = comboBoxMarkasi.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "HP":
                    comboBoxModeli.Items.Add("HP-15 DW4010NT");
                    comboBoxModeli.Items.Add("HP Victus 16-D1021NT");
                    comboBoxModeli.Items.Add("HP Omen-15 ek1xx");
                    break;
                case "Lenovo":
                    comboBoxModeli.Items.Add("Lenovo IdeaPad Gaming 3 82K201XDTX");
                    comboBoxModeli.Items.Add("Lenovo Legion 5 Pro 82RF00J3TX");
                    break;
                case "Dell":
                    comboBoxModeli.Items.Add("Dell Gaming G15 5530");
                    comboBoxModeli.Items.Add("Dell Inspiron 3511");
                    comboBoxModeli.Items.Add("Dell Vostro 3510");
                    break;

            }


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string value1 = selectedRow.Cells["musteriadi"].Value.ToString();
                string value2 = selectedRow.Cells["musterisoyadi"].Value.ToString();
                string value3 = selectedRow.Cells["telefon_num"].Value.ToString();
                string value4 = selectedRow.Cells["email"].Value.ToString();

                // Write the selected values to the TextBoxes
                textAd.Text = value1;
                textSoyad.Text = value2;
                textTelefon.Text = value3;
                textEmail.Text = value4;

            }
        }

        private void textAd_TextChanged(object sender, EventArgs e)
        {
            string searchText = textAd.Text.Trim();

            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM musteriliste WHERE musteriadi LIKE @SearchText";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void textSoyad_TextChanged(object sender, EventArgs e)
        {
            string searchText = textSoyad.Text.Trim();

            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM musteriliste WHERE musterisoyadi LIKE @SearchText";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

        private void textTelefon_TextChanged(object sender, EventArgs e)
        {
            string searchText = textTelefon.Text.Trim();

            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM musteriliste WHERE telefon_num LIKE @SearchText";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            string searchText = textEmail.Text.Trim();

            string connectionString = "server=localhost;database=computerservice;uid=root;password='';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM musteriliste WHERE email LIKE @SearchText";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Servis Uygulaması";
        }

        private void comboBoxModeli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxArizasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




