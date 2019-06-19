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

namespace HomeProject
{
    public partial class Form1 : Form
    {

        string query = "SELECT * FROM SpecialtyTable";
        string connectionString = @"Data Source=MSI\SECOND;Initial Catalog=bimboDB;Integrated Security=True;";

        //connection.Open();


        // Создаем объект DataAdapter
        SqlDataAdapter adapter;
        // Создаем объект Dataset
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        //private void LoadData()
        //{
        //    string connectionString = @"Data Source=MSI\SECOND;Initial Catalog=bimboDB;Integrated Security=True;";
        //    SqlConnection myConnection = new SqlConnection(connectionString);

        //    myConnection.Open();

        //    string query = "SELECT * FROM SpecialtyTable";

        //    SqlCommand command = new SqlCommand(query, myConnection);

        //    SqlDataReader reader = command.ExecuteReader();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SpecialtyTable";
            string connectionString = @"Data Source=MSI\SECOND;Initial Catalog=bimboDB;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            
            // Создаем объект DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            // Создаем объект Dataset
            DataSet ds = new DataSet();
            // Заполняем Dataset
            adapter.Fill(ds);
            // Отображаем данные
            dataGridView1.DataSource = ds.Tables[0];


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 form1 = new Form1();
            int column = e.RowIndex;        
            int row = e.ColumnIndex;    
            label1.Text = column.ToString() + row.ToString();

            string query2 = "SELECT * FROM GroupTable WHERE specialty = " + (e.RowIndex + 1);
            string connectionString = @"Data Source=MSI\SECOND;Initial Catalog=bimboDB;Integrated Security=True;";

            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connectionString);
                // Создаем объект Dataset
                DataSet ds2 = new DataSet();
                // Заполняем Dataset
                adapter2.Fill(ds2);
                // Отображаем данные
                dataGridView2.DataSource = ds2.Tables[0];            
        }
    }
}
