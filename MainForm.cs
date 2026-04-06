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

namespace GorbunovAEOKadrov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void тToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gorbunovOtdKadrDataSet1.Clear();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gorbunovOtdKadrDataSet1.sotrud_show_Proc". При необходимости она может быть перемещена или удалена.
            this.sotrud_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.sotrud_show_Proc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gorbunovOtdKadrDataSet1.otdel_show_Proc". При необходимости она может быть перемещена или удалена.
            this.otdel_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.otdel_show_Proc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gorbunovOtdKadrDataSet1.Dety". При необходимости она может быть перемещена или удалена.
            this.dety_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.dety_show_Proc);
            this.detyTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Dety);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gorbunovOtdKadrDataSet1.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gorbunovOtdKadrDataSet1.Otdel". При необходимости она может быть перемещена или удалена.
            this.otdelTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Otdel);

        }
        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddAction();
        }

        private void OtdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = otdel_show_ProcBindingSource1;
            dataGridView2.DataSource = OtdelBindingSource;
            dataGridView1.Update();
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void OtdelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void SotrudnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sotrud_show_ProcBindingSource1;
            dataGridView2.DataSource = SotrudBindingSource;
            dataGridView1.Update();
        }

        private void DetyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dety_show_ProcBindingSource1;
            dataGridView2.DataSource = DetyBindingSource;
            dataGridView1.Update();
        }
        string GetTableName()
        {
            string tableName = "";
            if (dataGridView1.DataSource == otdel_show_ProcBindingSource1)
            {
                tableName = "Otdel";
            }
            else if (dataGridView1.DataSource == sotrud_show_ProcBindingSource1)
            {
                tableName = "Sotrudnik";
            }
            else if (dataGridView1.DataSource == dety_show_ProcBindingSource1)
            {
                tableName = "Dety";
            }
            return tableName;
        }

        List<string> GetColHeaders(string tableName)
        {
            List<string> colHeaders = new List<string>();
            for (int i = 0; i < gorbunovOtdKadrDataSet1.Tables.Count; i++)
            {
                if (gorbunovOtdKadrDataSet1.Tables[i].TableName == tableName)
                {
                    for (int j = 0; j < gorbunovOtdKadrDataSet1.Tables[i].Columns.Count; j++)
                    {
                        colHeaders.Add(gorbunovOtdKadrDataSet1.Tables[i].Columns[j].ColumnName);
                    }
                }
            }
            return colHeaders;
        }
        public DataRow GetCurrentRow(DataGridView dgv)
        {
            CurrencyManager cm = (CurrencyManager)dgv.BindingContext[dgv.DataSource, dgv.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }
        private void DeleteRow(string tableName)
        {
            int index = dataGridView1.CurrentRow.Index;
            dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells[0];
            DataRow row = GetCurrentRow(dataGridView2);
            sqlConnection1.Open();
            try
            {
                if (tableName == "Otdel")
                {
                    int ID = (int)row["ID"];
                    OtdelsqlDataAdapter1.DeleteCommand.Parameters["@ID"].Value = ID;
                    OtdelsqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
                    this.otdel_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.otdel_show_Proc);
                    this.otdelTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Otdel);
                }
                else if (tableName == "Sotrudnik")
                {
                    int ID = (int)row["ID"];
                    SotrudsqlDataAdapter1.DeleteCommand.Parameters["@ID"].Value = ID;
                    SotrudsqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
                    this.sotrud_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.sotrud_show_Proc);
                    this.sotrudnikTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Sotrudnik);
                }
                else if (tableName == "Dety")
                {
                    int ID = (int)row["ID"];
                    DetysqlDataAdapter1.DeleteCommand.Parameters["@ID"].Value = ID;
                    DetysqlDataAdapter1.DeleteCommand.ExecuteNonQuery();
                    this.dety_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.dety_show_Proc);
                    this.detyTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Dety);
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
                errorMessage.Append("Ошибка при удалении записи.\n" +
                    "Запись не выбрана либо повреждена.");
                errorMessage.Append
                    ("Message: " + ex.Message + "\n" +
                    "Source: " + ex.Source + "\n");
                MessageBox.Show(errorMessage.ToString());
            }
            sqlConnection1.Close();
        }
        private void AddAction()
        {
            string tableName = GetTableName();
            if (tableName != "")
            {
                TableData tableData = new TableData
                { tableName = tableName, colHeaders = GetColHeaders(tableName) };
                var addForm = new EditForm(tableData, ref this.gorbunovOtdKadrDataSet1, "Insert");
                addForm.addData = AddData;
                addForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Таблица не выбрана.");
            }
        }
        public bool AddData(string tableName, Dictionary<string, string> data)
        {
            bool transactionSuccess = false;
            sqlConnection1.Open();
            try
            {
                if (tableName == "Otdel")
                {
                    //OtdelsqlDataAdapter1.InsertCommand.Parameters["@ID"].Value = Convert.ToInt32(data["ID"]);
                    OtdelsqlDataAdapter1.InsertCommand.Parameters["@nomerOtdela"].Value = Convert.ToInt32(data["nomerOtdela"]);
                    OtdelsqlDataAdapter1.InsertCommand.Parameters["@nazvanieOtdela"].Value = data["nazvanieOtdela"];
                    OtdelsqlDataAdapter1.InsertCommand.ExecuteNonQuery();
                    this.otdel_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.otdel_show_Proc);
                    this.otdelTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Otdel);
                }
                else if (tableName == "Sotrudnik")
                {
                    //SotrudsqlDataAdapter1.InsertCommand.Parameters["@ID"].Value = Convert.ToInt32(data["ID"]);
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@tabelNomerSotr"].Value = Convert.ToInt32(data["TabelNomerSotr"]);
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@familiya"].Value = data["Familiya"];
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@imya"].Value = data["Imya"];
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@otchestvo"].Value = data["Otchestvo"];
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@stazhRaboty"].Value = Convert.ToInt32(data["StazhRaboty"]);
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@polSotrudnika"].Value = data["PolSortudnika"];
                    SotrudsqlDataAdapter1.InsertCommand.Parameters["@Otdel_ID"].Value = data["Otdel_ID"];
                    SotrudsqlDataAdapter1.InsertCommand.ExecuteNonQuery();
                    this.sotrud_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.sotrud_show_Proc);
                    this.sotrudnikTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Sotrudnik);
                }
                else if (tableName == "Dety")
                {
                    //DetysqlDataAdapter1.InsertCommand.Parameters["@ID"].Value = data["ID"];
                    DetysqlDataAdapter1.InsertCommand.Parameters["@NomerSvidORozh"].Value = data["NomerSvidORozh"];
                    DetysqlDataAdapter1.InsertCommand.Parameters["@ImyaChildren"].Value = data["ImyaChildren"];
                    DetysqlDataAdapter1.InsertCommand.Parameters["@GodRozh"].Value = data["GodRozh"];
                    DetysqlDataAdapter1.InsertCommand.Parameters["@Pol"].Value = data["Pol"];
                    DetysqlDataAdapter1.InsertCommand.Parameters["@Sotrudnik_ID"].Value = Convert.ToInt32(data["Sotrudnik_ID"]);
                    DetysqlDataAdapter1.InsertCommand.ExecuteNonQuery();
                    this.dety_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.dety_show_Proc);
                    this.detyTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Dety);
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
        private void EditAction()
        {
            string tableName = GetTableName();
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                dataGridView2.CurrentCell = dataGridView2.Rows[index].Cells[0];
                DataRow row = GetCurrentRow(dataGridView2);
                Dictionary<string, int> pk = new Dictionary<string, int>();
                if (tableName == "Otdel")
                {
                    int OtdID = (int)row["ID"];
                    pk.Add("ID", OtdID);
                }
                else if (tableName == "Sotrudnik")
                {
                    int SotrID = (int)row["ID"];
                    pk.Add("ID", SotrID);
                    int OtdID = (int)row["Otdel_ID"];
                    pk.Add("Otdel_ID", OtdID);
                }
                else if (tableName == "Dety")
                {
                    int DetID = (int)row["ID"];
                    pk.Add("ID", DetID);
                    int SotrID = (int)row["Sotrudnik_ID"];
                    pk.Add("Sotrudnik_ID", SotrID);
                }
                TableData tableData = new TableData
                { tableName = tableName, colHeaders = GetColHeaders(tableName), pkValues = pk };
                var editForm = new EditForm(tableData, ref gorbunovOtdKadrDataSet1, "Update");
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
        public bool EditData(string tableName, Dictionary<string, string> data)
        {
            bool transactionSuccess = false;
            sqlConnection1.Open();
            try
            {
                if (tableName == "Otdel")
                {
                    OtdelsqlDataAdapter1.UpdateCommand.Parameters["@ID"].Value = Convert.ToInt32(data["ID"]);
                    OtdelsqlDataAdapter1.UpdateCommand.Parameters["@nomerOtdela"].Value = Convert.ToInt32(data["nomerOtdela"]);
                    OtdelsqlDataAdapter1.UpdateCommand.Parameters["@nazvanieOtdela"].Value = data["nazvanieOtdela"];
                    OtdelsqlDataAdapter1.UpdateCommand.ExecuteNonQuery();
                    this.otdel_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.otdel_show_Proc);
                    this.otdelTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Otdel);
                }
                else if (tableName == "Sotrudnik")
                {
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@ID"].Value = Convert.ToInt32(data["ID"]);
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@TabelNomerSotr"].Value = Convert.ToInt32(data["TabelNomerSotr"]);
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@Familiya"].Value = data["Familiya"];
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@Imya"].Value = data["Imya"];
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@Otchestvo"].Value = data["Otchestvo"];
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@StazhRaboty"].Value = Convert.ToInt32(data["StazhRaboty"]);
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@PolSotrudnika"].Value = data["PolSortudnika"];
                    SotrudsqlDataAdapter1.UpdateCommand.Parameters["@Otdel_ID"].Value = Convert.ToInt32(data["Otdel_ID"]);
                    SotrudsqlDataAdapter1.UpdateCommand.ExecuteNonQuery();
                    this.sotrud_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.sotrud_show_Proc);
                    this.sotrudnikTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Sotrudnik);
                }
                else if (tableName== "Dety")
                {
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@ID"].Value = Convert.ToInt32(data["ID"]);
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@NomerSvidORozh"].Value = data["NomerSvidORozh"];
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@ImyaChildren"].Value = data["ImyaChildren"];
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@GodRozh"].Value = Convert.ToInt32(data["GodRozh"]);
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@Pol"].Value = data["Pol"];
                    DetysqlDataAdapter1.UpdateCommand.Parameters["@Sotrudnik_ID"].Value = Convert.ToInt32(data["Sotrudnik_ID"]);
                    DetysqlDataAdapter1.UpdateCommand.ExecuteNonQuery();
                    this.dety_show_ProcTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.dety_show_Proc);
                    this.detyTableAdapter.Fill(this.gorbunovOtdKadrDataSet1.Dety);
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
        private void UpdateData()
        {
            OtdelsqlDataAdapter1.Update(gorbunovOtdKadrDataSet1);
            SotrudsqlDataAdapter1.Update(gorbunovOtdKadrDataSet1);
            DetysqlDataAdapter1.Update(gorbunovOtdKadrDataSet1);
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            OtdelsqlDataAdapter1.Fill(gorbunovOtdKadrDataSet1);
            SotrudsqlDataAdapter1.Fill(gorbunovOtdKadrDataSet1);
            DetysqlDataAdapter1.Fill(gorbunovOtdKadrDataSet1);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAction();
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow(GetTableName());
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteRow(GetTableName());
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAction();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAction();
        }

        private void SpisokDetyOtdelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportView = new ReportViewForm(0);
            reportView.ShowDialog();
        }

        private void иерархияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var treeView = new TreeViewForm(ref OtdelsqlDataAdapter2,
                ref ListDetyOtdela_ProcDataAdapter2, ref sqlConnection1, ref sqlConnection2);
            treeView.ShowDialog();
        }

        private void ListDetyOtdela_ProcDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        private void DetyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    public struct TableData
    {
        public string tableName;
        public List<string> colHeaders;
        public Dictionary<string, int> pkValues;
    }
}
