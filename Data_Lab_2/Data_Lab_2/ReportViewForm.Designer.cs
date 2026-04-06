
namespace Data_Lab_2
{
    partial class ReportViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource12 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.subListPage = new System.Windows.Forms.TabPage();
            this.lab2_db_KiselevDataSet = new Data_Lab_2.lab2_db_KiselevDataSet();
            this.subSum_Proc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subSum_Proc1TableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.subSum_Proc1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.titleCB = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.subSumPage = new System.Windows.Forms.TabPage();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.MagazineTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.subList_Proc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subList_Proc1TableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.subList_Proc1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.subListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_db_KiselevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subSum_Proc1BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.subSumPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subList_Proc1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.subListPage);
            this.tabControl1.Controls.Add(this.subSumPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // subListPage
            // 
            this.subListPage.Controls.Add(this.reportViewer2);
            this.subListPage.Controls.Add(this.panel1);
            this.subListPage.Location = new System.Drawing.Point(4, 22);
            this.subListPage.Name = "subListPage";
            this.subListPage.Padding = new System.Windows.Forms.Padding(3);
            this.subListPage.Size = new System.Drawing.Size(792, 424);
            this.subListPage.TabIndex = 1;
            this.subListPage.Text = "Список подписчиков";
            this.subListPage.UseVisualStyleBackColor = true;
            // 
            // lab2_db_KiselevDataSet
            // 
            this.lab2_db_KiselevDataSet.DataSetName = "lab2_db_KiselevDataSet";
            this.lab2_db_KiselevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subSum_Proc1BindingSource
            // 
            this.subSum_Proc1BindingSource.DataMember = "subSum_Proc1";
            this.subSum_Proc1BindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // subSum_Proc1TableAdapter
            // 
            this.subSum_Proc1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleCB);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 53);
            this.panel1.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(332, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = " Ввод";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // titleCB
            // 
            this.titleCB.DataSource = this.magazineBindingSource;
            this.titleCB.DisplayMember = "Title";
            this.titleCB.FormattingEnabled = true;
            this.titleCB.Location = new System.Drawing.Point(205, 19);
            this.titleCB.Name = "titleCB";
            this.titleCB.Size = new System.Drawing.Size(121, 21);
            this.titleCB.TabIndex = 1;
            this.titleCB.ValueMember = "Title";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource11.Name = "DataSet1";
            reportDataSource11.Value = this.subSum_Proc1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Data_Lab_2.Report_subSum.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(786, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // subSumPage
            // 
            this.subSumPage.Controls.Add(this.reportViewer1);
            this.subSumPage.Location = new System.Drawing.Point(4, 22);
            this.subSumPage.Name = "subSumPage";
            this.subSumPage.Padding = new System.Windows.Forms.Padding(3);
            this.subSumPage.Size = new System.Drawing.Size(792, 424);
            this.subSumPage.TabIndex = 0;
            this.subSumPage.Text = "Сумма подписок";
            this.subSumPage.UseVisualStyleBackColor = true;
            // 
            // magazineBindingSource
            // 
            this.magazineBindingSource.DataMember = "Magazine";
            this.magazineBindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // magazineTableAdapter
            // 
            this.magazineTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource12.Name = "DataSet1";
            reportDataSource12.Value = this.subList_Proc1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource12);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Data_Lab_2.Report_subList.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(786, 365);
            this.reportViewer2.TabIndex = 3;
            // 
            // subList_Proc1BindingSource
            // 
            this.subList_Proc1BindingSource.DataMember = "subList_Proc1";
            this.subList_Proc1BindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // subList_Proc1TableAdapter
            // 
            this.subList_Proc1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задать название издания: ";
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportViewForm";
            this.Text = "Просмотр отчетов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.subListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_db_KiselevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subSum_Proc1BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.subSumPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subList_Proc1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage subListPage;
        private System.Windows.Forms.BindingSource subSum_Proc1BindingSource;
        private lab2_db_KiselevDataSet lab2_db_KiselevDataSet;
        private lab2_db_KiselevDataSetTableAdapters.subSum_Proc1TableAdapter subSum_Proc1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox titleCB;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabPage subSumPage;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private lab2_db_KiselevDataSetTableAdapters.MagazineTableAdapter magazineTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource subList_Proc1BindingSource;
        private lab2_db_KiselevDataSetTableAdapters.subList_Proc1TableAdapter subList_Proc1TableAdapter;
        private System.Windows.Forms.Label label1;
    }
}