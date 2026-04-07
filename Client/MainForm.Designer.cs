namespace GorbunovAEOKadrov
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SotrudnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtchetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpisokDetyOtdelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.OtdelsqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.SotrudsqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.DetysqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.OtdelsqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.SotrudsqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.DetysqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.ListDetyOtdela_ProcDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.ListDetyOtdela_ProcDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.gorbunovOtdKadrDataSet1 = new GorbunovAEOKadrov.GorbunovOtdKadrDataSet();
            this.OtdelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otdelTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.OtdelTableAdapter();
            this.SotrudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrudnikTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.SotrudnikTableAdapter();
            this.DetyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detyTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.DetyTableAdapter();
            this.otdel_show_ProcBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.otdel_show_ProcTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.otdel_show_ProcTableAdapter();
            this.sotrud_show_ProcBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sotrud_show_ProcTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.sotrud_show_ProcTableAdapter();
            this.dety_show_ProcBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dety_show_ProcTableAdapter = new GorbunovAEOKadrov.GorbunovOtdKadrDataSetTableAdapters.dety_show_ProcTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorbunovOtdKadrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtdelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_show_ProcBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud_show_ProcBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dety_show_ProcBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TableToolStripMenuItem,
            this.OtchetToolStripMenuItem,
            this.TreeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TableToolStripMenuItem
            // 
            this.TableToolStripMenuItem.Checked = true;
            this.TableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OtdelToolStripMenuItem,
            this.SotrudnikToolStripMenuItem,
            this.DetyToolStripMenuItem});
            this.TableToolStripMenuItem.Name = "TableToolStripMenuItem";
            this.TableToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.TableToolStripMenuItem.Text = "Таблицы";
            // 
            // OtdelToolStripMenuItem
            // 
            this.OtdelToolStripMenuItem.Name = "OtdelToolStripMenuItem";
            this.OtdelToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.OtdelToolStripMenuItem.Text = "Список отделов";
            this.OtdelToolStripMenuItem.Click += new System.EventHandler(this.OtdelToolStripMenuItem_Click);
            // 
            // SotrudnikToolStripMenuItem
            // 
            this.SotrudnikToolStripMenuItem.Name = "SotrudnikToolStripMenuItem";
            this.SotrudnikToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.SotrudnikToolStripMenuItem.Text = "Список сотрудников";
            this.SotrudnikToolStripMenuItem.Click += new System.EventHandler(this.SotrudnikToolStripMenuItem_Click);
            // 
            // DetyToolStripMenuItem
            // 
            this.DetyToolStripMenuItem.Name = "DetyToolStripMenuItem";
            this.DetyToolStripMenuItem.Size = new System.Drawing.Size(334, 34);
            this.DetyToolStripMenuItem.Text = "Список детей сотрудников";
            this.DetyToolStripMenuItem.Click += new System.EventHandler(this.DetyToolStripMenuItem_Click);
            // 
            // OtchetToolStripMenuItem
            // 
            this.OtchetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpisokDetyOtdelToolStripMenuItem});
            this.OtchetToolStripMenuItem.Name = "OtchetToolStripMenuItem";
            this.OtchetToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.OtchetToolStripMenuItem.Text = "Отчеты";
            // 
            // SpisokDetyOtdelToolStripMenuItem
            // 
            this.SpisokDetyOtdelToolStripMenuItem.Name = "SpisokDetyOtdelToolStripMenuItem";
            this.SpisokDetyOtdelToolStripMenuItem.Size = new System.Drawing.Size(501, 34);
            this.SpisokDetyOtdelToolStripMenuItem.Text = "Список детей сотрудников выбранного отдела";
            this.SpisokDetyOtdelToolStripMenuItem.Click += new System.EventHandler(this.SpisokDetyOtdelToolStripMenuItem_Click);
            // 
            // TreeToolStripMenuItem
            // 
            this.TreeToolStripMenuItem.Name = "TreeToolStripMenuItem";
            this.TreeToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.TreeToolStripMenuItem.Text = "Группировка";
            this.TreeToolStripMenuItem.Click += new System.EventHandler(this.иерархияToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(791, 322);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 100);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(163, 32);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(163, 32);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(163, 32);
            this.DelToolStripMenuItem.Text = "Удалить";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 438);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DelButton);
            this.panel3.Controls.Add(this.EditButton);
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Location = new System.Drawing.Point(3, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 62);
            this.panel3.TabIndex = 1;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(336, 11);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(122, 41);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(178, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(122, 41);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(122, 41);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 48);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(794, 450);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GorbunovOtdKadr;Integrated Sec" +
    "urity=True;Pooling=False;Encrypt=False";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.otdel_show_Proc";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.otdel_add_Proc";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@nomerOtdela", System.Data.SqlDbType.Int, 4, "nomerOtdela"),
            new System.Data.SqlClient.SqlParameter("@nazvanieOtdela", System.Data.SqlDbType.NVarChar, 255, "nazvanieOtdela")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.otdel_mod_Proc";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"),
            new System.Data.SqlClient.SqlParameter("@nomerOtdela", System.Data.SqlDbType.Int, 4, "nomerOtdela"),
            new System.Data.SqlClient.SqlParameter("@nazvanieOtdela", System.Data.SqlDbType.NVarChar, 255, "nazvanieOtdela")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.otdel_del_Proc";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // OtdelsqlDataAdapter1
            // 
            this.OtdelsqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.OtdelsqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.OtdelsqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.OtdelsqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "otdel_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("nomerOtdela", "nomerOtdela"),
                        new System.Data.Common.DataColumnMapping("nazvanieOtdela", "nazvanieOtdela")})});
            this.OtdelsqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.sotrud_show_Proc";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "dbo.sotrud_add_Proc";
            this.sqlInsertCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@tabelNomerSotr", System.Data.SqlDbType.Int, 4, "TabelNomerSotr"),
            new System.Data.SqlClient.SqlParameter("@familiya", System.Data.SqlDbType.NVarChar, 50, "Familiya"),
            new System.Data.SqlClient.SqlParameter("@imya", System.Data.SqlDbType.NVarChar, 50, "Imya"),
            new System.Data.SqlClient.SqlParameter("@otchestvo", System.Data.SqlDbType.NVarChar, 50, "Otchestvo"),
            new System.Data.SqlClient.SqlParameter("@stazhRaboty", System.Data.SqlDbType.Int, 4, "StazhRaboty"),
            new System.Data.SqlClient.SqlParameter("@polSotrudnika", System.Data.SqlDbType.NChar, 1, "PolSortudnika"),
            new System.Data.SqlClient.SqlParameter("@Otdel_ID", System.Data.SqlDbType.Int, 4, "Otdel_ID")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = "dbo.sotrud_mod_Proc";
            this.sqlUpdateCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"),
            new System.Data.SqlClient.SqlParameter("@TabelNomerSotr", System.Data.SqlDbType.Int, 4, "TabelNomerSotr"),
            new System.Data.SqlClient.SqlParameter("@Familiya", System.Data.SqlDbType.NVarChar, 50, "Familiya"),
            new System.Data.SqlClient.SqlParameter("@Imya", System.Data.SqlDbType.NVarChar, 50, "Imya"),
            new System.Data.SqlClient.SqlParameter("@Otchestvo", System.Data.SqlDbType.NVarChar, 50, "Otchestvo"),
            new System.Data.SqlClient.SqlParameter("@StazhRaboty", System.Data.SqlDbType.Int, 4, "StazhRaboty"),
            new System.Data.SqlClient.SqlParameter("@PolSotrudnika", System.Data.SqlDbType.NChar, 1, "PolSortudnika"),
            new System.Data.SqlClient.SqlParameter("@Otdel_ID", System.Data.SqlDbType.Int, 4, "Otdel_ID")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "dbo.sotrud_del_Proc";
            this.sqlDeleteCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // SotrudsqlDataAdapter1
            // 
            this.SotrudsqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand2;
            this.SotrudsqlDataAdapter1.InsertCommand = this.sqlInsertCommand2;
            this.SotrudsqlDataAdapter1.SelectCommand = this.sqlSelectCommand2;
            this.SotrudsqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sotrud_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("TabelNomerSotr", "TabelNomerSotr"),
                        new System.Data.Common.DataColumnMapping("Familiya", "Familiya"),
                        new System.Data.Common.DataColumnMapping("Imya", "Imya"),
                        new System.Data.Common.DataColumnMapping("Otchestvo", "Otchestvo"),
                        new System.Data.Common.DataColumnMapping("StazhRaboty", "StazhRaboty"),
                        new System.Data.Common.DataColumnMapping("PolSortudnika", "PolSortudnika"),
                        new System.Data.Common.DataColumnMapping("Otdel_ID", "Otdel_ID")})});
            this.SotrudsqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.dety_show_Proc";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = "dbo.dety_add_Proc";
            this.sqlInsertCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NomerSvidORozh", System.Data.SqlDbType.NVarChar, 15, "NomerSvidORozh"),
            new System.Data.SqlClient.SqlParameter("@ImyaChildren", System.Data.SqlDbType.NVarChar, 50, "ImyaChildren"),
            new System.Data.SqlClient.SqlParameter("@GodRozh", System.Data.SqlDbType.Int, 4, "GodRozh"),
            new System.Data.SqlClient.SqlParameter("@Pol", System.Data.SqlDbType.NChar, 1, "Pol"),
            new System.Data.SqlClient.SqlParameter("@Sotrudnik_ID", System.Data.SqlDbType.Int, 4, "Sotrudnik_ID")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = "dbo.dety_mod_Proc";
            this.sqlUpdateCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"),
            new System.Data.SqlClient.SqlParameter("@NomerSvidORozh", System.Data.SqlDbType.NVarChar, 15, "NomerSvidORozh"),
            new System.Data.SqlClient.SqlParameter("@ImyaChildren", System.Data.SqlDbType.NVarChar, 50, "ImyaChildren"),
            new System.Data.SqlClient.SqlParameter("@GodRozh", System.Data.SqlDbType.Int, 4, "GodRozh"),
            new System.Data.SqlClient.SqlParameter("@Pol", System.Data.SqlDbType.NChar, 1, "Pol"),
            new System.Data.SqlClient.SqlParameter("@Sotrudnik_ID", System.Data.SqlDbType.Int, 4, "Sotrudnik_ID")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "dbo.dety_del_Proc";
            this.sqlDeleteCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // DetysqlDataAdapter1
            // 
            this.DetysqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand3;
            this.DetysqlDataAdapter1.InsertCommand = this.sqlInsertCommand3;
            this.DetysqlDataAdapter1.SelectCommand = this.sqlSelectCommand3;
            this.DetysqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "dety_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("NomerSvidORozh", "NomerSvidORozh"),
                        new System.Data.Common.DataColumnMapping("ImyaChildren", "ImyaChildren"),
                        new System.Data.Common.DataColumnMapping("GodRozh", "GodRozh"),
                        new System.Data.Common.DataColumnMapping("Pol", "Pol"),
                        new System.Data.Common.DataColumnMapping("Sotrudnik_ID", "Sotrudnik_ID")})});
            this.DetysqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // OtdelsqlDataAdapter2
            // 
            this.OtdelsqlDataAdapter2.SelectCommand = this.sqlCommand3;
            this.OtdelsqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "otdel_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("nomerOtdela", "nomerOtdela"),
                        new System.Data.Common.DataColumnMapping("nazvanieOtdela", "nazvanieOtdela")})});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "dbo.otdel_show_Proc";
            this.sqlCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand3.Connection = this.sqlConnection1;
            this.sqlCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // SotrudsqlDataAdapter2
            // 
            this.SotrudsqlDataAdapter2.SelectCommand = this.sqlCommand4;
            this.SotrudsqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sotrud_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("TabelNomerSotr", "TabelNomerSotr"),
                        new System.Data.Common.DataColumnMapping("Familiya", "Familiya"),
                        new System.Data.Common.DataColumnMapping("Imya", "Imya"),
                        new System.Data.Common.DataColumnMapping("Otchestvo", "Otchestvo"),
                        new System.Data.Common.DataColumnMapping("StazhRaboty", "StazhRaboty"),
                        new System.Data.Common.DataColumnMapping("PolSortudnika", "PolSortudnika"),
                        new System.Data.Common.DataColumnMapping("Otdel_ID", "Otdel_ID")})});
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "dbo.sotrud_show_Proc";
            this.sqlCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand4.Connection = this.sqlConnection1;
            this.sqlCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // DetysqlDataAdapter2
            // 
            this.DetysqlDataAdapter2.SelectCommand = this.sqlCommand5;
            this.DetysqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "dety_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("NomerSvidORozh", "NomerSvidORozh"),
                        new System.Data.Common.DataColumnMapping("ImyaChildren", "ImyaChildren"),
                        new System.Data.Common.DataColumnMapping("GodRozh", "GodRozh"),
                        new System.Data.Common.DataColumnMapping("Pol", "Pol"),
                        new System.Data.Common.DataColumnMapping("Sotrudnik_ID", "Sotrudnik_ID")})});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "dbo.dety_show_Proc";
            this.sqlCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlCommand5.Connection = this.sqlConnection1;
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "dbo.List_Dety_Otdela_Proc";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@nazvanie_otdela", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "ОЗИ")});
            // 
            // ListDetyOtdela_ProcDataAdapter1
            // 
            this.ListDetyOtdela_ProcDataAdapter1.SelectCommand = this.sqlSelectCommand4;
            this.ListDetyOtdela_ProcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "List_Dety_Otdela_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ChildrenInfo", "ChildrenInfo"),
                        new System.Data.Common.DataColumnMapping("SotrudnikInfo", "SotrudnikInfo"),
                        new System.Data.Common.DataColumnMapping("OtdelInfo", "OtdelInfo")})});
            this.ListDetyOtdela_ProcDataAdapter1.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.ListDetyOtdela_ProcDataAdapter1_RowUpdated);
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GorbunovOtdKadr;Integrated Sec" +
    "urity=True;Encrypt=False";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "dbo.List_Dety_Otdela_Proc";
            this.sqlSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand5.Connection = this.sqlConnection2;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@nazvanie_otdela", System.Data.SqlDbType.NVarChar, 255)});
            // 
            // ListDetyOtdela_ProcDataAdapter2
            // 
            this.ListDetyOtdela_ProcDataAdapter2.SelectCommand = this.sqlSelectCommand5;
            this.ListDetyOtdela_ProcDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "List_Dety_Otdela_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ChildrenInfo", "ChildrenInfo"),
                        new System.Data.Common.DataColumnMapping("SotrudnikInfo", "SotrudnikInfo"),
                        new System.Data.Common.DataColumnMapping("OtdelInfo", "OtdelInfo")})});
            // 
            // gorbunovOtdKadrDataSet1
            // 
            this.gorbunovOtdKadrDataSet1.DataSetName = "GorbunovOtdKadrDataSet";
            this.gorbunovOtdKadrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OtdelBindingSource
            // 
            this.OtdelBindingSource.DataMember = "Otdel";
            this.OtdelBindingSource.DataSource = this.gorbunovOtdKadrDataSet1;
            this.OtdelBindingSource.CurrentChanged += new System.EventHandler(this.OtdelBindingSource_CurrentChanged);
            // 
            // otdelTableAdapter
            // 
            this.otdelTableAdapter.ClearBeforeFill = true;
            // 
            // SotrudBindingSource
            // 
            this.SotrudBindingSource.DataMember = "Sotrudnik";
            this.SotrudBindingSource.DataSource = this.gorbunovOtdKadrDataSet1;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // DetyBindingSource
            // 
            this.DetyBindingSource.DataMember = "Dety";
            this.DetyBindingSource.DataSource = this.gorbunovOtdKadrDataSet1;
            this.DetyBindingSource.CurrentChanged += new System.EventHandler(this.DetyBindingSource_CurrentChanged);
            // 
            // detyTableAdapter
            // 
            this.detyTableAdapter.ClearBeforeFill = true;
            // 
            // otdel_show_ProcBindingSource1
            // 
            this.otdel_show_ProcBindingSource1.DataMember = "otdel_show_Proc";
            this.otdel_show_ProcBindingSource1.DataSource = this.gorbunovOtdKadrDataSet1;
            // 
            // otdel_show_ProcTableAdapter
            // 
            this.otdel_show_ProcTableAdapter.ClearBeforeFill = true;
            // 
            // sotrud_show_ProcBindingSource1
            // 
            this.sotrud_show_ProcBindingSource1.DataMember = "sotrud_show_Proc";
            this.sotrud_show_ProcBindingSource1.DataSource = this.gorbunovOtdKadrDataSet1;
            // 
            // sotrud_show_ProcTableAdapter
            // 
            this.sotrud_show_ProcTableAdapter.ClearBeforeFill = true;
            // 
            // dety_show_ProcBindingSource1
            // 
            this.dety_show_ProcBindingSource1.DataMember = "dety_show_Proc";
            this.dety_show_ProcBindingSource1.DataSource = this.gorbunovOtdKadrDataSet1;
            // 
            // dety_show_ProcTableAdapter
            // 
            this.dety_show_ProcTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Горбунов А.Е. База данных \"Отдел кадров\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gorbunovOtdKadrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtdelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SotrudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otdel_show_ProcBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrud_show_ProcBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dety_show_ProcBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OtdelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SotrudnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OtchetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpisokDetyOtdelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter OtdelsqlDataAdapter1;
        internal System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter SotrudsqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter DetysqlDataAdapter1;
        internal GorbunovOtdKadrDataSet gorbunovOtdKadrDataSet1;
        private System.Windows.Forms.BindingSource OtdelBindingSource;
        private GorbunovOtdKadrDataSetTableAdapters.OtdelTableAdapter otdelTableAdapter;
        private System.Windows.Forms.BindingSource SotrudBindingSource;
        private GorbunovOtdKadrDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource DetyBindingSource;
        private GorbunovOtdKadrDataSetTableAdapters.DetyTableAdapter detyTableAdapter;
        private System.Windows.Forms.BindingSource otdel_show_ProcBindingSource1;
        private GorbunovOtdKadrDataSetTableAdapters.otdel_show_ProcTableAdapter otdel_show_ProcTableAdapter;
        private System.Windows.Forms.BindingSource sotrud_show_ProcBindingSource1;
        private GorbunovOtdKadrDataSetTableAdapters.sotrud_show_ProcTableAdapter sotrud_show_ProcTableAdapter;
        private System.Windows.Forms.BindingSource dety_show_ProcBindingSource1;
        private GorbunovOtdKadrDataSetTableAdapters.dety_show_ProcTableAdapter dety_show_ProcTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Data.SqlClient.SqlDataAdapter OtdelsqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Data.SqlClient.SqlDataAdapter SotrudsqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlDataAdapter DetysqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter ListDetyOtdela_ProcDataAdapter1;
        private System.Windows.Forms.ToolStripMenuItem TreeToolStripMenuItem;
        internal System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlDataAdapter ListDetyOtdela_ProcDataAdapter2;
    }
}
