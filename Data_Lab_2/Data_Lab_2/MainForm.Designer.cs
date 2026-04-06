namespace Data_Lab_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subSumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.magDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.shmDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.subDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.subListDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.subSumDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sqlSelectCommand6 = new System.Data.SqlClient.SqlCommand();
            this.magDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand7 = new System.Data.SqlClient.SqlCommand();
            this.shmDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand8 = new System.Data.SqlClient.SqlCommand();
            this.subDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.lab2_db_KiselevDataSet = new Data_Lab_2.lab2_db_KiselevDataSet();
            this.magazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazineTableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.MagazineTableAdapter();
            this.subscriberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriberTableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.SubscriberTableAdapter();
            this.subscriberhasmagazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriber_has_magazineTableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.Subscriber_has_magazineTableAdapter();
            this.shmshowProc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shm_show_Proc1TableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.shm_show_Proc1TableAdapter();
            this.magshowProc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mag_show_Proc1TableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.mag_show_Proc1TableAdapter();
            this.subshowProc1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sub_show_Proc1TableAdapter = new Data_Lab_2.lab2_db_KiselevDataSetTableAdapters.sub_show_Proc1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_db_KiselevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberhasmagazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shmshowProc1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magshowProc1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subshowProc1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.editStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addStripMenuItem.Text = "Добавить";
            this.addStripMenuItem.Click += new System.EventHandler(this.addStripMenuItem_Click);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editStripMenuItem.Text = "Изменить";
            this.editStripMenuItem.Click += new System.EventHandler(this.editStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(174, 15);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(93, 15);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=lab2_db_Kiselev;Integrated Sec" +
    "urity=True; MultipleActiveResultSets=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magToolStripMenuItem,
            this.subToolStripMenuItem,
            this.shmToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tablesToolStripMenuItem.Text = "Таблица";
            // 
            // magToolStripMenuItem
            // 
            this.magToolStripMenuItem.Name = "magToolStripMenuItem";
            this.magToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.magToolStripMenuItem.Text = "Издания";
            this.magToolStripMenuItem.Click += new System.EventHandler(this.magToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.subToolStripMenuItem.Text = "Подписчики";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // shmToolStripMenuItem
            // 
            this.shmToolStripMenuItem.Name = "shmToolStripMenuItem";
            this.shmToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.shmToolStripMenuItem.Text = "Подписки на издания";
            this.shmToolStripMenuItem.Click += new System.EventHandler(this.shmToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subListToolStripMenuItem,
            this.subSumToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.queryToolStripMenuItem.Text = "Отчеты";
            // 
            // subListToolStripMenuItem
            // 
            this.subListToolStripMenuItem.Name = "subListToolStripMenuItem";
            this.subListToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.subListToolStripMenuItem.Text = "Список подписчиков";
            this.subListToolStripMenuItem.Click += new System.EventHandler(this.subListToolStripMenuItem_Click);
            // 
            // subSumToolStripMenuItem
            // 
            this.subSumToolStripMenuItem.Name = "subSumToolStripMenuItem";
            this.subSumToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.subSumToolStripMenuItem.Text = "Сумма подписки";
            this.subSumToolStripMenuItem.Click += new System.EventHandler(this.subSumToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.TreeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TreeToolStripMenuItem
            // 
            this.TreeToolStripMenuItem.Name = "TreeToolStripMenuItem";
            this.TreeToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.TreeToolStripMenuItem.Text = "Иерархия";
            this.TreeToolStripMenuItem.Click += new System.EventHandler(this.TreeToolStripMenuItem_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.mag_show_Proc";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.mag_add_Proc";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.Int, 4, "Zipcode"),
            new System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.NVarChar, 255, "Title"),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Float, 8, "Cost")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.mag_mod_Proc";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID"),
            new System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.Int, 4, "Zipcode"),
            new System.Data.SqlClient.SqlParameter("@title", System.Data.SqlDbType.NVarChar, 255, "Title"),
            new System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Float, 8, "Cost")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.mag_del_Proc";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // magDataAdapter
            // 
            this.magDataAdapter.DeleteCommand = this.sqlDeleteCommand1;
            this.magDataAdapter.InsertCommand = this.sqlInsertCommand1;
            this.magDataAdapter.SelectCommand = this.sqlSelectCommand1;
            this.magDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "mag_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Zipcode", "Zipcode"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost")})});
            this.magDataAdapter.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.shm_show_Proc";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "dbo.shm_add_Proc";
            this.sqlInsertCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@sub_id", System.Data.SqlDbType.Int, 4, "Subscriber_ID"),
            new System.Data.SqlClient.SqlParameter("@mag_id", System.Data.SqlDbType.Int, 4, "Magazine_ID"),
            new System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.TinyInt, 1, "Amount")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = "dbo.shm_mod_Proc";
            this.sqlUpdateCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@sub_id", System.Data.SqlDbType.Int, 4, "Subscriber_ID"),
            new System.Data.SqlClient.SqlParameter("@mag_id", System.Data.SqlDbType.Int, 4, "Magazine_ID"),
            new System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.TinyInt, 1, "Amount")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "dbo.shm_del_Proc";
            this.sqlDeleteCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@sub_id", System.Data.SqlDbType.Int, 4, "Subscriber_ID"),
            new System.Data.SqlClient.SqlParameter("@mag_id", System.Data.SqlDbType.Int, 4, "Magazine_ID")});
            // 
            // shmDataAdapter
            // 
            this.shmDataAdapter.DeleteCommand = this.sqlDeleteCommand2;
            this.shmDataAdapter.InsertCommand = this.sqlInsertCommand2;
            this.shmDataAdapter.SelectCommand = this.sqlSelectCommand2;
            this.shmDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "shm_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Subscriber_ID", "Subscriber_ID"),
                        new System.Data.Common.DataColumnMapping("Magazine_ID", "Magazine_ID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("MagInfo", "MagInfo"),
                        new System.Data.Common.DataColumnMapping("MagCost", "MagCost"),
                        new System.Data.Common.DataColumnMapping("SubInfo", "SubInfo")})});
            this.shmDataAdapter.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.sub_show_Proc";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = "dbo.sub_add_Proc";
            this.sqlInsertCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@subname", System.Data.SqlDbType.NVarChar, 255, "SubName"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 255, "Address")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = "dbo.sub_mod_Proc";
            this.sqlUpdateCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID"),
            new System.Data.SqlClient.SqlParameter("@subname", System.Data.SqlDbType.NVarChar, 255, "SubName"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.NVarChar, 255, "Address")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "dbo.sub_del_Proc";
            this.sqlDeleteCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "ID")});
            // 
            // subDataAdapter
            // 
            this.subDataAdapter.DeleteCommand = this.sqlDeleteCommand3;
            this.subDataAdapter.InsertCommand = this.sqlInsertCommand3;
            this.subDataAdapter.SelectCommand = this.sqlSelectCommand3;
            this.subDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sub_show_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SubName", "SubName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")})});
            this.subDataAdapter.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "dbo.subList_Proc";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@mag_title", System.Data.SqlDbType.NVarChar, 255)});
            // 
            // subListDataAdapter
            // 
            this.subListDataAdapter.SelectCommand = this.sqlSelectCommand4;
            this.subListDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "subList_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SubName", "SubName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")})});
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "dbo.subSum_Proc";
            this.sqlSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // subSumDataAdapter
            // 
            this.subSumDataAdapter.SelectCommand = this.sqlSelectCommand5;
            this.subSumDataAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "subSum_Proc", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SubName", "SubName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address"),
                        new System.Data.Common.DataColumnMapping("MagInfo", "MagInfo"),
                        new System.Data.Common.DataColumnMapping("SubSum", "SubSum")})});
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(502, 282);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 284);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 24);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.DelButton);
            this.panel2.Controls.Add(this.EditButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 50);
            this.panel2.TabIndex = 6;
            // 
            // sqlSelectCommand6
            // 
            this.sqlSelectCommand6.CommandText = "dbo.mag_select_Proc2";
            this.sqlSelectCommand6.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand6.Connection = this.sqlConnection1;
            this.sqlSelectCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4)});
            // 
            // magDataAdapter2
            // 
            this.magDataAdapter2.SelectCommand = this.sqlSelectCommand6;
            this.magDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "mag_select_Proc2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Zipcode", "Zipcode"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Zipcode", "Zipcode"),
                        new System.Data.Common.DataColumnMapping("Title", "Title"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost")})});
            // 
            // sqlSelectCommand7
            // 
            this.sqlSelectCommand7.CommandText = "dbo.shm_select_Proc2";
            this.sqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand7.Connection = this.sqlConnection1;
            this.sqlSelectCommand7.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@offset", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // shmDataAdapter2
            // 
            this.shmDataAdapter2.SelectCommand = this.sqlSelectCommand7;
            this.shmDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "shm_select_Proc2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Subscriber_ID", "Subscriber_ID"),
                        new System.Data.Common.DataColumnMapping("Magazine_ID", "Magazine_ID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            // 
            // sqlSelectCommand8
            // 
            this.sqlSelectCommand8.CommandText = "dbo.sub_select_Proc2";
            this.sqlSelectCommand8.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand8.Connection = this.sqlConnection1;
            this.sqlSelectCommand8.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4)});
            // 
            // subDataAdapter2
            // 
            this.subDataAdapter2.SelectCommand = this.sqlSelectCommand8;
            this.subDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "sub_select_Proc2", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("SubName", "SubName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("SubName", "SubName"),
                        new System.Data.Common.DataColumnMapping("Address", "Address")})});
            // 
            // lab2_db_KiselevDataSet
            // 
            this.lab2_db_KiselevDataSet.DataSetName = "lab2_db_KiselevDataSet";
            this.lab2_db_KiselevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // subscriberBindingSource
            // 
            this.subscriberBindingSource.DataMember = "Subscriber";
            this.subscriberBindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // subscriberTableAdapter
            // 
            this.subscriberTableAdapter.ClearBeforeFill = true;
            // 
            // subscriberhasmagazineBindingSource
            // 
            this.subscriberhasmagazineBindingSource.DataMember = "Subscriber_has_magazine";
            this.subscriberhasmagazineBindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // subscriber_has_magazineTableAdapter
            // 
            this.subscriber_has_magazineTableAdapter.ClearBeforeFill = true;
            // 
            // shmshowProc1BindingSource
            // 
            this.shmshowProc1BindingSource.DataMember = "shm_show_Proc1";
            this.shmshowProc1BindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // shm_show_Proc1TableAdapter
            // 
            this.shm_show_Proc1TableAdapter.ClearBeforeFill = true;
            // 
            // magshowProc1BindingSource
            // 
            this.magshowProc1BindingSource.DataMember = "mag_show_Proc1";
            this.magshowProc1BindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // mag_show_Proc1TableAdapter
            // 
            this.mag_show_Proc1TableAdapter.ClearBeforeFill = true;
            // 
            // subshowProc1BindingSource
            // 
            this.subshowProc1BindingSource.DataMember = "sub_show_Proc1";
            this.subshowProc1BindingSource.DataSource = this.lab2_db_KiselevDataSet;
            // 
            // sub_show_Proc1TableAdapter
            // 
            this.sub_show_Proc1TableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(504, 284);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Управление данными - Лаб. 2";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lab2_db_KiselevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriberhasmagazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shmshowProc1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magshowProc1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subshowProc1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subSumToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter magDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter shmDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter subDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlDataAdapter subListDataAdapter;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlDataAdapter subSumDataAdapter;
        internal System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.BindingSource magazineBindingSource;
        private lab2_db_KiselevDataSetTableAdapters.MagazineTableAdapter magazineTableAdapter;
        private System.Windows.Forms.BindingSource subscriberBindingSource;
        private lab2_db_KiselevDataSetTableAdapters.SubscriberTableAdapter subscriberTableAdapter;
        private System.Windows.Forms.BindingSource subscriberhasmagazineBindingSource;
        private lab2_db_KiselevDataSetTableAdapters.Subscriber_has_magazineTableAdapter subscriber_has_magazineTableAdapter;
        internal lab2_db_KiselevDataSet lab2_db_KiselevDataSet;
        private System.Windows.Forms.BindingSource shmshowProc1BindingSource;
        private lab2_db_KiselevDataSetTableAdapters.shm_show_Proc1TableAdapter shm_show_Proc1TableAdapter;
        private System.Windows.Forms.BindingSource magshowProc1BindingSource;
        private lab2_db_KiselevDataSetTableAdapters.mag_show_Proc1TableAdapter mag_show_Proc1TableAdapter;
        private System.Windows.Forms.BindingSource subshowProc1BindingSource;
        private lab2_db_KiselevDataSetTableAdapters.sub_show_Proc1TableAdapter sub_show_Proc1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem TreeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand6;
        private System.Data.SqlClient.SqlDataAdapter magDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand7;
        private System.Data.SqlClient.SqlDataAdapter shmDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand8;
        private System.Data.SqlClient.SqlDataAdapter subDataAdapter2;
    }
}

