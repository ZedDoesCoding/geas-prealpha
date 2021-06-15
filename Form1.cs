using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace geas_prealpha_001
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A1LD558\\SQLEXPRESS;Initial Catalog=Geas;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
            ViewData();
        }

        private void prodottiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodottiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.geasDataSet);

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Prodotti", con);
            dt = new DataTable();
            adpt.Fill(dt);
            prodottiDataGridView.DataSource = dt;
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*
                private void Add_Butt_Click(object sender, EventArgs e)
                {
                  
                    
                        cmd = new SqlCommand("insert into Prodotti (codice,produttore,tipo,prezzo) values (@codice,@produttore,@tipo,@prezzo)", con);

                          con.Open();
                          cmd.Parameters.AddWithValue("@codice", codiceTextBox.Text);
                          cmd.Parameters.AddWithValue("@produttore", produttoreTextBox.Text);
                          cmd.Parameters.AddWithValue("@tipo", tipoTextBox.Text);
                          cmd.Parameters.AddWithValue("@prezzo", prezzoTextBox.Text);
                          cmd.ExecuteNonQuery();
                          con.Close();
                          MessageBox.Show("Record Inserted Successfully");
                          ViewData();
                          ClearData();


                    



            }*/


        private void Add_Butt_Click(object sender, EventArgs e)
        {
           
        }
        private void ClearData()
        {
            codiceTextBox.Text = "";
            produttoreTextBox.Text = "";
            tipoTextBox.Text = "";
            prezzoTextBox.Text = "";
            ID = 0;



        }
        public void ViewData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Prodotti", con);
            dt = new DataTable();
            adpt.Fill(dt);
            prodottiDataGridView.DataSource = dt;
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBox1.Text);
        }
        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from Prodotti where Codice like '%" + search + "%'";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            prodottiDataGridView.DataSource = dt;
            con.Close();
        }

        private void codiceLabel_Click(object sender, EventArgs e)
        {

        }
       
       
        private void prodottiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-A1LD558\\SQLEXPRESS;Initial Catalog=Geas;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT INTO Prodotti (codice,produttore,tipo,prezzo) VALUES(@codice,@produttore,@tipo,@prezzo)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@codice", codiceTextBox.Text);
            command.Parameters.AddWithValue("@produttore", produttoreTextBox.Text);
            command.Parameters.AddWithValue("@tipo", tipoTextBox.Text);
            command.Parameters.AddWithValue("@prezzo", prezzoTextBox.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
                ViewData();
            }

        }

        private void delbutt_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-A1LD558\\SQLEXPRESS;Initial Catalog=Geas;Integrated Security=True";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "DELETE FROM Prodotti WHERE (ID) =  (@id)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", ID);
          
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Records removed Successfully");
            }
            catch (SqlException)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
                ViewData();
            }


        }
    }
}
