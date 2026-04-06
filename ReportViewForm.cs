using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorbunovAEOKadrov
{
    public partial class ReportViewForm : Form
    {
        public ReportViewForm(int tabIndex)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = tabIndex;

        }

        private void ReportViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GorbunovOtdKadrDataSet.Otdel' table. You can move, or remove it, as needed.
            this.otdelTableAdapter1.Fill(this.gorbunovOtdKadrDataSet.Otdel);
            BuildListDetySotrOtdReport();
            //this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildListDetySotrOtdReport();
        }
        void BuildListDetySotrOtdReport()
        {
            string nazvanie_otdela = nazvOtdCB.SelectedValue.ToString();
            this.list_Dety_Otdela_ProcTableAdapter1.Fill(this.gorbunovOtdKadrDataSet.List_Dety_Otdela_Proc, nazvanie_otdela);
            Microsoft.Reporting.WinForms.ReportParameter rParamTitle =
                new Microsoft.Reporting.WinForms.ReportParameter("nazvanie_otdela", nazvanie_otdela);
            reportViewer1.LocalReport.SetParameters(rParamTitle);
            reportViewer1.RefreshReport();
        }

        private void nazvOtdCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
