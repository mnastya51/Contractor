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
    public partial class ContragentForm : Form
    {
        public string connectionString;
        public ContragentForm()
        {
            connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ACCOUNT_GRAIN.MDF; Integrated Security = True";
            InitializeComponent();
        }

        private void addContragentButton_Click(object sender, EventArgs e)
        {
            new AddContragentForm().ShowDialog();
            this.сontractorTableAdapter.Fill(this.account_grainDataSet.Сontractor);
        }

        private void ContragentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "account_grainDataSet.Сontractor". При необходимости она может быть перемещена или удалена.
            сontractorTableAdapter.Fill(this.account_grainDataSet.Сontractor);
            dataGridView1.ClearSelection();
        }

        private void changeContragentButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Contractor contr = new Contractor(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value), Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value), Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value));
                var addContragentForm = new AddContragentForm(contr);
                addContragentForm.ShowDialog();
                this.сontractorTableAdapter.Fill(this.account_grainDataSet.Сontractor);
            }
            catch (Exception) { MessageBox.Show("Выберите контрагента!", "Измнение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void removeContagentButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    Contractor contr = new Contractor(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    string sql = string.Format("Delete from Сontractor where id_contractor='{0}'", contr.Id);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    this.сontractorTableAdapter.Fill(this.account_grainDataSet.Сontractor);
                }
            }
            catch (System.ArgumentOutOfRangeException ) { MessageBox.Show("Выберите контрагента!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error); }                     
        }
     
        private void findContragentButton_Click_1(object sender, EventArgs e)
        {
            if (contragentTextBox.Text.Trim().Equals(""))
                MessageBox.Show("Введите наименование контрагента!", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string sql = string.Format("Select * From Сontractor where UPPER(REPLACE(name_contractor,' ','')) LIKE(UPPER(REPLACE('{0}',' ','')))", " %" + contragentTextBox.Text.Trim() + "%");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, "Сontractor");
                    connection.Close();
                    contragentTextBox.Clear();
                    if (dataAdapter.Fill(ds) == 0)
                        MessageBox.Show("Данный контрагент не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        dataGridView1.DataSource = ds.Tables["Сontractor"].DefaultView;
                }
                dataGridView1.ClearSelection();
            }
        }

        private void showAllContrButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(string.Format("Select * From Сontractor"), connection);
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Сontractor");
                connection.Close();
                dataGridView1.DataSource = ds.Tables["Сontractor"].DefaultView;
            }
            dataGridView1.ClearSelection();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            new ContracrotRecportForm().ShowDialog();
        }
    }          
}
