namespace GorbunovAEOKadrov
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.List_Dety_Otdela_ProcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gorbunovOtdKadrDataSet = new GorbunovAEOKadrov.GorbunovOtdKadrDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListDetSotrOtdPage = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nazvOtdCB = new System.Windows.Forms.ComboBox();
            this.OtdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.otdelTableAdapter1 = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.OtdelTableAdapter();
            this.list_Dety_Otdela_ProcTableAdapter1 = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.List_Dety_Otdela_ProcTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.List_Dety_Otdela_ProcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorbunovOtdKadrDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ListDetSotrOtdPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtdelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // List_Dety_Otdela_ProcBindingSource
            // 
            this.List_Dety_Otdela_ProcBindingSource.DataMember = "List_Dety_Otdela_Proc";
            this.List_Dety_Otdela_ProcBindingSource.DataSource = this.gorbunovOtdKadrDataSet;
            // 
            // gorbunovOtdKadrDataSet
            // 
            this.gorbunovOtdKadrDataSet.DataSetName = "GorbunovOtdKadrDataSet";
            this.gorbunovOtdKadrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListDetSotrOtdPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // ListDetSotrOtdPage
            // 
            this.ListDetSotrOtdPage.Controls.Add(this.reportViewer1);
            this.ListDetSotrOtdPage.Controls.Add(this.panel1);
            this.ListDetSotrOtdPage.Location = new System.Drawing.Point(4, 29);
            this.ListDetSotrOtdPage.Name = "ListDetSotrOtdPage";
            this.ListDetSotrOtdPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListDetSotrOtdPage.Size = new System.Drawing.Size(1023, 596);
            this.ListDetSotrOtdPage.TabIndex = 0;
            this.ListDetSotrOtdPage.Text = "Список детей сотрудников конкретного отдела";
            this.ListDetSotrOtdPage.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.List_Dety_Otdela_ProcBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GorbunovAEOKadrov.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1017, 528);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nazvOtdCB);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(3, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название отдела";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nazvOtdCB
            // 
            this.nazvOtdCB.DataSource = this.OtdelBindingSource;
            this.nazvOtdCB.DisplayMember = "nazvanieOtdela";
            this.nazvOtdCB.FormattingEnabled = true;
            this.nazvOtdCB.Location = new System.Drawing.Point(233, 19);
            this.nazvOtdCB.Name = "nazvOtdCB";
            this.nazvOtdCB.Size = new System.Drawing.Size(138, 28);
            this.nazvOtdCB.TabIndex = 1;
            this.nazvOtdCB.ValueMember = "nazvanieOtdela";
            this.nazvOtdCB.SelectedIndexChanged += new System.EventHandler(this.nazvOtdCB_SelectedIndexChanged);
            // 
            // OtdelBindingSource
            // 
            this.OtdelBindingSource.DataMember = "Otdel";
            this.OtdelBindingSource.DataSource = this.gorbunovOtdKadrDataSet;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(416, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 48);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Ввод";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // otdelTableAdapter1
            // 
            this.otdelTableAdapter1.ClearBeforeFill = true;
            // 
            // list_Dety_Otdela_ProcTableAdapter1
            // 
            this.list_Dety_Otdela_ProcTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportViewForm";
            this.Text = "Просмотр отчетов";
            this.Load += new System.EventHandler(this.ReportViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_Dety_Otdela_ProcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorbunovOtdKadrDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ListDetSotrOtdPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtdelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListDetSotrOtdPage;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox nazvOtdCB;
        private GorbunovOtdKadrDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter1;
        private GorbunovOtdKadrDataSet gorbunovOtdKadrDataSet;
        private GorbunovOtdKadrDataSetTableAdapters.List_Dety_Otdela_ProcTableAdapter list_Dety_Otdela_ProcTableAdapter1;
        private System.Windows.Forms.BindingSource OtdelBindingSource;
        private System.Windows.Forms.BindingSource List_Dety_Otdela_ProcBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}
