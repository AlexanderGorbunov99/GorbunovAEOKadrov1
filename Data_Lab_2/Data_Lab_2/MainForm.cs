using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data_Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.sub_show_Proc1' table. You can move, or remove it, as needed.
            this.sub_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.sub_show_Proc1);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.mag_show_Proc1' table. You can move, or remove it, as needed.
            this.mag_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.mag_show_Proc1);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.shm_show_Proc1' table. You can move, or remove it, as needed.
            this.shm_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.shm_show_Proc1);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.Subscriber_has_magazine' table. You can move, or remove it, as needed.
            this.subscriber_has_magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber_has_magazine);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.Subscriber' table. You can move, or remove it, as needed.
            this.subscriberTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.Magazine' table. You can move, or remove it, as needed.
            this.magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Magazine);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.sub_View' table. You can move, or remove it, as needed.
            

        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void magToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = magshowProc1BindingSource;
            dataGridView2.DataSource = magazineBindingSource;
            dataGridView1.Update();
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = subshowProc1BindingSource;
            dataGridView2.DataSource = subscriberBindingSource;
            dataGridView1.Update();
        }

        private void shmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = shmshowProc1BindingSource;
            dataGridView2.DataSource = subscriberhasmagazineBindingSource;
            dataGridView1.Update();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow(GetTableName());
        }

        string GetTableName()
        {
            string tableName = "";
            if (dataGridView1.DataSource == magshowProc1BindingSource)
            {
                tableName = "Magazine";
            }
            else if (dataGridView1.DataSource == subshowProc1BindingSource)
            {
                tableName = "Subscriber";
            }
            else if (dataGridView1.DataSource == shmshowProc1BindingSource)
            {
                tableName = "Subscriber_has_magazine";
            }
            return tableName;
        }

        List<string> GetColHeaders(string tableName)
        {
            List<string> colHeaders = new List<string>();
            for (int i = 0; i<lab2_db_KiselevDataSet.Tables.Count; i++)
            {
                if (lab2_db_KiselevDataSet.Tables[i].TableName == tableName)
                {
                    for (int j = 0; j< lab2_db_KiselevDataSet.Tables[i].Columns.Count; j++)
                    {
                        colHeaders.Add(lab2_db_KiselevDataSet.Tables[i].Columns[j].ColumnName);
                    }
                }
            }
            return colHeaders;
        }
        private void AddAction()
        {
            string tableName = GetTableName();
            if (tableName != "")
            {
                TableData tableData = new TableData
                { tableName = tableName, colHeaders = GetColHeaders(tableName) };
                var addForm = new EditForm(tableData, ref this.lab2_db_KiselevDataSet, "Insert");
                addForm.addData = AddData;
                addForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Таблица не выбрана.");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAction();
        }
        private void EditAction()
        {
            string tableName = GetTableName();
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells[0];
                DataRow row = GetCurrentRow(dataGridView2);
                Dictionary<string, int> pk = new Dictionary<string, int>();
                if (tableName == "Subscriber")
                {
                    int SubID = (int)row["ID"];
                    pk.Add("ID", SubID);
                }
                else if (tableName == "Magazine")
                {
                    int MagID = (int)row["ID"];
                    pk.Add("ID", MagID);
                }
                else if (tableName == "Subscriber_has_magazine")
                {
                    int SubID = (int)row["Subscriber_ID"];
                    pk.Add("Subscriber_ID", SubID);
                    int MagID = (int)row["Magazine_ID"];
                    pk.Add("Magazine_ID", MagID);
                }
                TableData tableData = new TableData
                { tableName = tableName, colHeaders = GetColHeaders(tableName), pkValues = pk };
                var editForm = new EditForm(tableData, ref lab2_db_KiselevDataSet, "Update");
                editForm.editData = EditData;
                editForm.ShowDialog();
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.Append("Ошибка при изменении записи.\n" +
                    "Запись не выбрана либо повреждена.");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAction();
        }

        public DataRow GetCurrentRow(DataGridView dgv)
        {
            CurrencyManager cm = (CurrencyManager)dgv.BindingContext[dgv.DataSource, dgv.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }


        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteRow(GetTableName());
        }

        private void DeleteRow(string tableName)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells[0];
            DataRow row = GetCurrentRow(dataGridView2);
            sqlConnection1.Open();
            try
            {
                if (tableName == "Subscriber")
                {
                    int SubID = (int)row["ID"];
                    subDataAdapter.DeleteCommand.Parameters["@id"].Value = SubID;
                    subDataAdapter.DeleteCommand.ExecuteNonQuery();
                    this.sub_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.sub_show_Proc1);
                    this.subscriberTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber);
                }
                else if (tableName == "Magazine")
                {
                    int MagID = (int)row["ID"];
                    magDataAdapter.DeleteCommand.Parameters["@id"].Value = MagID;
                    magDataAdapter.DeleteCommand.ExecuteNonQuery();
                    this.mag_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.mag_show_Proc1);
                    this.magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Magazine);
                }
                else if (tableName == "Subscriber_has_magazine")
                {
                    int SubID = (int)row["Subscriber_ID"];
                    int MagID = (int)row["Magazine_ID"];
                    shmDataAdapter.DeleteCommand.Parameters["@sub_id"].Value = SubID;
                    shmDataAdapter.DeleteCommand.Parameters["@mag_id"].Value = MagID;
                    shmDataAdapter.DeleteCommand.ExecuteNonQuery();
                    this.shm_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.shm_show_Proc1);
                    this.subscriber_has_magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber_has_magazine);
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append
                        ("Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.Append("Ошибка при удалении записи.\n"+
                    "Запись не выбрана либо повреждена.");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
            }
            sqlConnection1.Close();
        }

        private void UpdateData()
        {
            magDataAdapter.Update(lab2_db_KiselevDataSet);
            shmDataAdapter.Update(lab2_db_KiselevDataSet);
            subDataAdapter.Update(lab2_db_KiselevDataSet);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            magDataAdapter.Fill(lab2_db_KiselevDataSet);
            shmDataAdapter.Fill(lab2_db_KiselevDataSet);
            subDataAdapter.Fill(lab2_db_KiselevDataSet);
        }

        public bool AddData(string tableName, Dictionary<string, string> data)
        {
            bool transactionSuccess = false;
            sqlConnection1.Open();
            try
            {
                if (tableName == "Subscriber")
                {
                    subDataAdapter.InsertCommand.Parameters["@subname"].Value = data["SubName"];
                    subDataAdapter.InsertCommand.Parameters["@address"].Value = data["Address"];
                    subDataAdapter.InsertCommand.ExecuteNonQuery();
                    this.sub_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.sub_show_Proc1);
                    this.subscriberTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber);
                }
                else if (tableName == "Magazine")
                {
                    magDataAdapter.InsertCommand.Parameters["@zipcode"].Value = Convert.ToInt32(data["Zipcode"]);
                    magDataAdapter.InsertCommand.Parameters["@title"].Value = data["Title"];
                    magDataAdapter.InsertCommand.Parameters["@cost"].Value = Convert.ToSingle(data["Cost"]);
                    magDataAdapter.InsertCommand.ExecuteNonQuery();
                    this.mag_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.mag_show_Proc1);
                    this.magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Magazine);
                }
                else if (tableName == "Subscriber_has_magazine")
                {
                    shmDataAdapter.InsertCommand.Parameters["@sub_id"].Value = Convert.ToInt32(data["Subscriber_ID"]);
                    shmDataAdapter.InsertCommand.Parameters["@mag_id"].Value = Convert.ToInt32(data["Magazine_ID"]);
                    shmDataAdapter.InsertCommand.Parameters["@amount"].Value = Convert.ToInt32(data["Amount"]);
                    shmDataAdapter.InsertCommand.ExecuteNonQuery();
                    this.shm_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.shm_show_Proc1);
                    this.subscriber_has_magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber_has_magazine);
                }
                transactionSuccess = true;
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append
                        ("Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                transactionSuccess = false;
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.Append("Ошибка при добавлении записи.");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
                transactionSuccess = false;
            }
            sqlConnection1.Close();
            return transactionSuccess;
        }
        public bool EditData(string tableName, Dictionary<string, string> data)
        {
            bool transactionSuccess = false;
            sqlConnection1.Open();
            try
            {
                if (tableName == "Subscriber")
                {
                    subDataAdapter.UpdateCommand.Parameters["@id"].Value = Convert.ToInt32(data["ID"]);
                    subDataAdapter.UpdateCommand.Parameters["@subname"].Value = data["SubName"];
                    subDataAdapter.UpdateCommand.Parameters["@address"].Value = data["Address"];
                    subDataAdapter.UpdateCommand.ExecuteNonQuery();
                    this.sub_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.sub_show_Proc1);
                    this.subscriberTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber);
                }
                else if (tableName == "Magazine")
                {
                    magDataAdapter.UpdateCommand.Parameters["@id"].Value = Convert.ToInt32(data["ID"]);
                    magDataAdapter.UpdateCommand.Parameters["@zipcode"].Value = Convert.ToInt32(data["Zipcode"]);
                    magDataAdapter.UpdateCommand.Parameters["@title"].Value = data["Title"];
                    magDataAdapter.UpdateCommand.Parameters["@cost"].Value = Convert.ToSingle(data["Cost"]);
                    magDataAdapter.UpdateCommand.ExecuteNonQuery();
                    this.mag_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.mag_show_Proc1);
                    this.magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Magazine);
                }
                else if (tableName == "Subscriber_has_magazine")
                {
                    shmDataAdapter.UpdateCommand.Parameters["@sub_id"].Value = Convert.ToInt32(data["Subscriber_ID"]);
                    shmDataAdapter.UpdateCommand.Parameters["@mag_id"].Value = Convert.ToInt32(data["Magazine_ID"]);
                    shmDataAdapter.UpdateCommand.Parameters["@amount"].Value = Convert.ToInt32(data["Amount"]);
                    shmDataAdapter.UpdateCommand.ExecuteNonQuery();
                    this.shm_show_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.shm_show_Proc1);
                    this.subscriber_has_magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Subscriber_has_magazine);
                }
                transactionSuccess = true;
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append
                        ("Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show(errorMessages.ToString());
                transactionSuccess = false;
            }
            catch (Exception ex)
            {
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.Append("Ошибка при изменении записи.");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
                transactionSuccess = false;
            }
            sqlConnection1.Close();
            return transactionSuccess;
        }

        private void editStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAction();
        }

        private void addStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAction();
        }

        private void TreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var treeView = new TreeViewForm(ref magDataAdapter,
                ref subListDataAdapter, ref sqlConnection1 );
            treeView.ShowDialog();
        }

        private void subListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportView = new ReportViewForm(0);
            reportView.ShowDialog();
        }

        private void subSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportView = new ReportViewForm(1);
            reportView.ShowDialog();
        }
    }

    public struct TableData
    {
        public string tableName;
        public List<string> colHeaders;
        public Dictionary<string, int> pkValues;
    }
}
