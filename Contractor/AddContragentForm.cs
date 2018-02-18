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

namespace Contractor
{
    public partial class AddContragentForm : Form
    {
        
        public string connectionString;
        public Contractor contr;
        public AddContragentForm()
        {
            InitializeComponent();
        }
        public AddContragentForm(Contractor con)
        {
            InitializeComponent();
            contr = con;
            nameContrTextBox.Text = con.Name;
            subTextBox.Text = con.Sub;
            yurAdressTextBox.Text = con.YurAdress;
            factAdressTextBox.Text = con.FactAdress;
            indexTextBox.Text = con.Index.ToString();
            phoneTextBox.Text = con.Phone;
            innTextBox.Text = con.Inn;
            this.Text = "Изменение контрагента";
        }
       
        private void saveContrButton_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ACCOUNT_GRAIN.MDF; Integrated Security = True";
            if (contr == null)
            {
                contr = new Contractor(nameContrTextBox.Text, subTextBox.Text, yurAdressTextBox.Text, factAdressTextBox.Text, Convert.ToInt32(indexTextBox.Text), phoneTextBox.Text, innTextBox.Text);
                string sql = "Insert into Сontractor (name_contractor,subdivision,jur_address,fact_address,mail_index,phone,inn) values (@name_contractor, @subdivision, @jur_address, @fact_address, @mail_index, @phone, @inn)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    cmd.Parameters.AddWithValue("@name_contractor", contr.Name);
                    cmd.Parameters.AddWithValue("@subdivision", contr.Sub);
                    cmd.Parameters.AddWithValue("@jur_address", contr.YurAdress);
                    cmd.Parameters.AddWithValue("@fact_address", contr.FactAdress);
                    cmd.Parameters.AddWithValue("@mail_index", contr.Index);
                    cmd.Parameters.AddWithValue("@phone", contr.Phone);
                    cmd.Parameters.AddWithValue("@inn", contr.Inn);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                contr.Name = nameContrTextBox.Text;
                contr.Sub = subTextBox.Text;
                contr.YurAdress = yurAdressTextBox.Text;
                contr.FactAdress = factAdressTextBox.Text;
                contr.Index = Convert.ToInt32(indexTextBox.Text);
                contr.Phone = phoneTextBox.Text;
                contr.Inn=innTextBox.Text;
                string sql = string.Format("Update Сontractor Set name_contractor='{0}',subdivision='{1}', jur_address='{2}', fact_address='{3}', mail_index='{4}', phone='{5}', inn='{6}' where id_contractor='{7}'",
                contr.Name, contr.Sub, contr.YurAdress, contr.FactAdress, contr.Index, contr.Phone, contr.Inn, contr.Id);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            
            this.Close();
        }
    }
}
