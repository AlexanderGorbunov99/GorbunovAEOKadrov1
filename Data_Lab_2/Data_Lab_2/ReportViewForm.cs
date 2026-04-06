using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Lab_2
{
    public partial class ReportViewForm : Form
    {
        public ReportViewForm(int tabIndex)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = tabIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.Magazine' table. You can move, or remove it, as needed.
            this.magazineTableAdapter.Fill(this.lab2_db_KiselevDataSet.Magazine);
            // TODO: This line of code loads data into the 'lab2_db_KiselevDataSet.subSum_Proc1' table. You can move, or remove it, as needed.
            this.subSum_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.subSum_Proc1);
            this.reportViewer1.RefreshReport();
            BuildSubListReport();
            //this.reportViewer2.RefreshReport();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BuildSubListReport();
        }
        void BuildSubListReport()
        {
            string mag_title = titleCB.SelectedValue.ToString();
            this.subList_Proc1TableAdapter.Fill(this.lab2_db_KiselevDataSet.subList_Proc1, mag_title);
            Microsoft.Reporting.WinForms.ReportParameter rParamTitle =
                new Microsoft.Reporting.WinForms.ReportParameter("mag_title", mag_title);
            reportViewer2.LocalReport.SetParameters(rParamTitle);
            reportViewer2.RefreshReport();
        }
    }
}
