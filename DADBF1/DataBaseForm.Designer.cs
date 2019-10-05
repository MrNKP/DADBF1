namespace DADBF1
{
    partial class DataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseForm));
            this.dataBaseTabs = new System.Windows.Forms.TabControl();
            this.teamPage = new System.Windows.Forms.TabPage();
            this.teamsAddBtn = new System.Windows.Forms.Button();
            this.teamsShowBtn = new System.Windows.Forms.Button();
            this.teamsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.driversPage = new System.Windows.Forms.TabPage();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.driversAddBtn = new System.Windows.Forms.Button();
            this.driversShowBtn = new System.Windows.Forms.Button();
            this.carsPage = new System.Windows.Forms.TabPage();
            this.racesPage = new System.Windows.Forms.TabPage();
            this.loggedLbl = new System.Windows.Forms.Label();
            this.loggedUsernameLbl = new System.Windows.Forms.Label();
            this.seasonLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.carsShowBtn = new System.Windows.Forms.Button();
            this.carsAddBtn = new System.Windows.Forms.Button();
            this.driverEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.driverDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.carEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.podiumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trophiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.results10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerengDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueleffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams1DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseTabs.SuspendLayout();
            this.teamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView1)).BeginInit();
            this.driversPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            this.carsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBaseTabs
            // 
            this.dataBaseTabs.Controls.Add(this.teamPage);
            this.dataBaseTabs.Controls.Add(this.driversPage);
            this.dataBaseTabs.Controls.Add(this.carsPage);
            this.dataBaseTabs.Controls.Add(this.racesPage);
            this.dataBaseTabs.Location = new System.Drawing.Point(12, 40);
            this.dataBaseTabs.Name = "dataBaseTabs";
            this.dataBaseTabs.SelectedIndex = 0;
            this.dataBaseTabs.Size = new System.Drawing.Size(1369, 362);
            this.dataBaseTabs.TabIndex = 0;
            // 
            // teamPage
            // 
            this.teamPage.Controls.Add(this.teamsAddBtn);
            this.teamPage.Controls.Add(this.teamsShowBtn);
            this.teamPage.Controls.Add(this.teamsDataGridView1);
            this.teamPage.Location = new System.Drawing.Point(4, 25);
            this.teamPage.Name = "teamPage";
            this.teamPage.Padding = new System.Windows.Forms.Padding(3);
            this.teamPage.Size = new System.Drawing.Size(1361, 333);
            this.teamPage.TabIndex = 0;
            this.teamPage.Text = "Teams";
            this.teamPage.UseVisualStyleBackColor = true;
            // 
            // teamsAddBtn
            // 
            this.teamsAddBtn.Location = new System.Drawing.Point(1238, 58);
            this.teamsAddBtn.Name = "teamsAddBtn";
            this.teamsAddBtn.Size = new System.Drawing.Size(116, 46);
            this.teamsAddBtn.TabIndex = 2;
            this.teamsAddBtn.Text = "Add";
            this.teamsAddBtn.UseVisualStyleBackColor = true;
            // 
            // teamsShowBtn
            // 
            this.teamsShowBtn.Location = new System.Drawing.Point(1239, 6);
            this.teamsShowBtn.Name = "teamsShowBtn";
            this.teamsShowBtn.Size = new System.Drawing.Size(116, 46);
            this.teamsShowBtn.TabIndex = 1;
            this.teamsShowBtn.Text = "Show";
            this.teamsShowBtn.UseVisualStyleBackColor = true;
            // 
            // teamsDataGridView1
            // 
            this.teamsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView1.Location = new System.Drawing.Point(6, 6);
            this.teamsDataGridView1.Name = "teamsDataGridView1";
            this.teamsDataGridView1.ReadOnly = true;
            this.teamsDataGridView1.RowTemplate.Height = 24;
            this.teamsDataGridView1.Size = new System.Drawing.Size(1226, 321);
            this.teamsDataGridView1.TabIndex = 0;
            // 
            // driversPage
            // 
            this.driversPage.Controls.Add(this.driversDataGridView);
            this.driversPage.Controls.Add(this.driversAddBtn);
            this.driversPage.Controls.Add(this.driversShowBtn);
            this.driversPage.Location = new System.Drawing.Point(4, 25);
            this.driversPage.Name = "driversPage";
            this.driversPage.Padding = new System.Windows.Forms.Padding(3);
            this.driversPage.Size = new System.Drawing.Size(1361, 333);
            this.driversPage.TabIndex = 1;
            this.driversPage.Text = "Drivers";
            this.driversPage.UseVisualStyleBackColor = true;
            // 
            // driversDataGridView
            // 
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.podiumsDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.trophiesDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.pointsDataGridViewTextBoxColumn,
            this.resultsDataGridViewTextBoxColumn,
            this.results1DataGridViewTextBoxColumn,
            this.results2DataGridViewTextBoxColumn,
            this.results3DataGridViewTextBoxColumn,
            this.results4DataGridViewTextBoxColumn,
            this.results5DataGridViewTextBoxColumn,
            this.results6DataGridViewTextBoxColumn,
            this.results7DataGridViewTextBoxColumn,
            this.results8DataGridViewTextBoxColumn,
            this.results9DataGridViewTextBoxColumn,
            this.results10DataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn,
            this.teams1DataGridViewTextBoxColumn,
            this.driverEdit,
            this.driverDelete});
            this.driversDataGridView.DataSource = this.driverBindingSource2;
            this.driversDataGridView.Location = new System.Drawing.Point(7, 7);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.ReadOnly = true;
            this.driversDataGridView.RowTemplate.Height = 24;
            this.driversDataGridView.Size = new System.Drawing.Size(1226, 320);
            this.driversDataGridView.TabIndex = 0;
            this.driversDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driversDataGridView_CellContentClick);
            // 
            // driversAddBtn
            // 
            this.driversAddBtn.Location = new System.Drawing.Point(1239, 59);
            this.driversAddBtn.Name = "driversAddBtn";
            this.driversAddBtn.Size = new System.Drawing.Size(116, 46);
            this.driversAddBtn.TabIndex = 2;
            this.driversAddBtn.Text = "Add";
            this.driversAddBtn.UseVisualStyleBackColor = true;
            this.driversAddBtn.Click += new System.EventHandler(this.driversAddBtn_Click);
            // 
            // driversShowBtn
            // 
            this.driversShowBtn.Location = new System.Drawing.Point(1239, 7);
            this.driversShowBtn.Name = "driversShowBtn";
            this.driversShowBtn.Size = new System.Drawing.Size(116, 46);
            this.driversShowBtn.TabIndex = 1;
            this.driversShowBtn.Text = "Show";
            this.driversShowBtn.UseVisualStyleBackColor = true;
            this.driversShowBtn.Click += new System.EventHandler(this.driversShowBtn_Click);
            // 
            // carsPage
            // 
            this.carsPage.Controls.Add(this.carsAddBtn);
            this.carsPage.Controls.Add(this.carsShowBtn);
            this.carsPage.Controls.Add(this.carsDataGridView);
            this.carsPage.Location = new System.Drawing.Point(4, 25);
            this.carsPage.Name = "carsPage";
            this.carsPage.Padding = new System.Windows.Forms.Padding(3);
            this.carsPage.Size = new System.Drawing.Size(1361, 333);
            this.carsPage.TabIndex = 2;
            this.carsPage.Text = "Cars";
            this.carsPage.UseVisualStyleBackColor = true;
            // 
            // racesPage
            // 
            this.racesPage.Location = new System.Drawing.Point(4, 25);
            this.racesPage.Name = "racesPage";
            this.racesPage.Padding = new System.Windows.Forms.Padding(3);
            this.racesPage.Size = new System.Drawing.Size(1361, 333);
            this.racesPage.TabIndex = 3;
            this.racesPage.Text = "Races";
            this.racesPage.UseVisualStyleBackColor = true;
            // 
            // loggedLbl
            // 
            this.loggedLbl.AutoSize = true;
            this.loggedLbl.Location = new System.Drawing.Point(13, 405);
            this.loggedLbl.Name = "loggedLbl";
            this.loggedLbl.Size = new System.Drawing.Size(88, 17);
            this.loggedLbl.TabIndex = 1;
            this.loggedLbl.Text = "Logged As : ";
            // 
            // loggedUsernameLbl
            // 
            this.loggedUsernameLbl.AutoSize = true;
            this.loggedUsernameLbl.Location = new System.Drawing.Point(107, 405);
            this.loggedUsernameLbl.Name = "loggedUsernameLbl";
            this.loggedUsernameLbl.Size = new System.Drawing.Size(135, 17);
            this.loggedUsernameLbl.TabIndex = 2;
            this.loggedUsernameLbl.Text = "loggedUsernameLbl";
            // 
            // seasonLbl
            // 
            this.seasonLbl.AutoSize = true;
            this.seasonLbl.Location = new System.Drawing.Point(13, 13);
            this.seasonLbl.Name = "seasonLbl";
            this.seasonLbl.Size = new System.Drawing.Size(68, 17);
            this.seasonLbl.TabIndex = 3;
            this.seasonLbl.Text = "Season : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1294, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.powerengDataGridViewTextBoxColumn,
            this.fueleffDataGridViewTextBoxColumn,
            this.resourseDataGridViewTextBoxColumn,
            this.carweightDataGridViewTextBoxColumn,
            this.teamsDataGridViewTextBoxColumn1,
            this.teams1DataGridViewTextBoxColumn1,
            this.carEdit,
            this.Column1});
            this.carsDataGridView.DataSource = this.carBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(7, 7);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowTemplate.Height = 24;
            this.carsDataGridView.Size = new System.Drawing.Size(1226, 320);
            this.carsDataGridView.TabIndex = 0;
            // 
            // carsShowBtn
            // 
            this.carsShowBtn.Location = new System.Drawing.Point(1240, 7);
            this.carsShowBtn.Name = "carsShowBtn";
            this.carsShowBtn.Size = new System.Drawing.Size(116, 46);
            this.carsShowBtn.TabIndex = 1;
            this.carsShowBtn.Text = "Show";
            this.carsShowBtn.UseVisualStyleBackColor = true;
            this.carsShowBtn.Click += new System.EventHandler(this.carsShowBtn_Click);
            // 
            // carsAddBtn
            // 
            this.carsAddBtn.Location = new System.Drawing.Point(1239, 59);
            this.carsAddBtn.Name = "carsAddBtn";
            this.carsAddBtn.Size = new System.Drawing.Size(116, 46);
            this.carsAddBtn.TabIndex = 2;
            this.carsAddBtn.Text = "Add";
            this.carsAddBtn.UseVisualStyleBackColor = true;
            // 
            // driverEdit
            // 
            this.driverEdit.HeaderText = "";
            this.driverEdit.Name = "driverEdit";
            this.driverEdit.ReadOnly = true;
            this.driverEdit.Text = "Edit";
            this.driverEdit.UseColumnTextForButtonValue = true;
            // 
            // driverDelete
            // 
            this.driverDelete.HeaderText = "";
            this.driverDelete.Name = "driverDelete";
            this.driverDelete.ReadOnly = true;
            this.driverDelete.Text = "Delete";
            this.driverDelete.UseColumnTextForButtonValue = true;
            // 
            // carEdit
            // 
            this.carEdit.HeaderText = "";
            this.carEdit.Name = "carEdit";
            this.carEdit.ReadOnly = true;
            this.carEdit.Text = "Edit";
            this.carEdit.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            this.familynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "birth";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // podiumsDataGridViewTextBoxColumn
            // 
            this.podiumsDataGridViewTextBoxColumn.DataPropertyName = "podiums";
            this.podiumsDataGridViewTextBoxColumn.HeaderText = "podiums";
            this.podiumsDataGridViewTextBoxColumn.Name = "podiumsDataGridViewTextBoxColumn";
            this.podiumsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trophiesDataGridViewTextBoxColumn
            // 
            this.trophiesDataGridViewTextBoxColumn.DataPropertyName = "trophies";
            this.trophiesDataGridViewTextBoxColumn.HeaderText = "trophies";
            this.trophiesDataGridViewTextBoxColumn.Name = "trophiesDataGridViewTextBoxColumn";
            this.trophiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultsDataGridViewTextBoxColumn
            // 
            this.resultsDataGridViewTextBoxColumn.DataPropertyName = "results";
            this.resultsDataGridViewTextBoxColumn.HeaderText = "results";
            this.resultsDataGridViewTextBoxColumn.Name = "resultsDataGridViewTextBoxColumn";
            this.resultsDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultsDataGridViewTextBoxColumn.Visible = false;
            // 
            // results1DataGridViewTextBoxColumn
            // 
            this.results1DataGridViewTextBoxColumn.DataPropertyName = "results1";
            this.results1DataGridViewTextBoxColumn.HeaderText = "results1";
            this.results1DataGridViewTextBoxColumn.Name = "results1DataGridViewTextBoxColumn";
            this.results1DataGridViewTextBoxColumn.ReadOnly = true;
            this.results1DataGridViewTextBoxColumn.Visible = false;
            // 
            // results2DataGridViewTextBoxColumn
            // 
            this.results2DataGridViewTextBoxColumn.DataPropertyName = "results2";
            this.results2DataGridViewTextBoxColumn.HeaderText = "results2";
            this.results2DataGridViewTextBoxColumn.Name = "results2DataGridViewTextBoxColumn";
            this.results2DataGridViewTextBoxColumn.ReadOnly = true;
            this.results2DataGridViewTextBoxColumn.Visible = false;
            // 
            // results3DataGridViewTextBoxColumn
            // 
            this.results3DataGridViewTextBoxColumn.DataPropertyName = "results3";
            this.results3DataGridViewTextBoxColumn.HeaderText = "results3";
            this.results3DataGridViewTextBoxColumn.Name = "results3DataGridViewTextBoxColumn";
            this.results3DataGridViewTextBoxColumn.ReadOnly = true;
            this.results3DataGridViewTextBoxColumn.Visible = false;
            // 
            // results4DataGridViewTextBoxColumn
            // 
            this.results4DataGridViewTextBoxColumn.DataPropertyName = "results4";
            this.results4DataGridViewTextBoxColumn.HeaderText = "results4";
            this.results4DataGridViewTextBoxColumn.Name = "results4DataGridViewTextBoxColumn";
            this.results4DataGridViewTextBoxColumn.ReadOnly = true;
            this.results4DataGridViewTextBoxColumn.Visible = false;
            // 
            // results5DataGridViewTextBoxColumn
            // 
            this.results5DataGridViewTextBoxColumn.DataPropertyName = "results5";
            this.results5DataGridViewTextBoxColumn.HeaderText = "results5";
            this.results5DataGridViewTextBoxColumn.Name = "results5DataGridViewTextBoxColumn";
            this.results5DataGridViewTextBoxColumn.ReadOnly = true;
            this.results5DataGridViewTextBoxColumn.Visible = false;
            // 
            // results6DataGridViewTextBoxColumn
            // 
            this.results6DataGridViewTextBoxColumn.DataPropertyName = "results6";
            this.results6DataGridViewTextBoxColumn.HeaderText = "results6";
            this.results6DataGridViewTextBoxColumn.Name = "results6DataGridViewTextBoxColumn";
            this.results6DataGridViewTextBoxColumn.ReadOnly = true;
            this.results6DataGridViewTextBoxColumn.Visible = false;
            // 
            // results7DataGridViewTextBoxColumn
            // 
            this.results7DataGridViewTextBoxColumn.DataPropertyName = "results7";
            this.results7DataGridViewTextBoxColumn.HeaderText = "results7";
            this.results7DataGridViewTextBoxColumn.Name = "results7DataGridViewTextBoxColumn";
            this.results7DataGridViewTextBoxColumn.ReadOnly = true;
            this.results7DataGridViewTextBoxColumn.Visible = false;
            // 
            // results8DataGridViewTextBoxColumn
            // 
            this.results8DataGridViewTextBoxColumn.DataPropertyName = "results8";
            this.results8DataGridViewTextBoxColumn.HeaderText = "results8";
            this.results8DataGridViewTextBoxColumn.Name = "results8DataGridViewTextBoxColumn";
            this.results8DataGridViewTextBoxColumn.ReadOnly = true;
            this.results8DataGridViewTextBoxColumn.Visible = false;
            // 
            // results9DataGridViewTextBoxColumn
            // 
            this.results9DataGridViewTextBoxColumn.DataPropertyName = "results9";
            this.results9DataGridViewTextBoxColumn.HeaderText = "results9";
            this.results9DataGridViewTextBoxColumn.Name = "results9DataGridViewTextBoxColumn";
            this.results9DataGridViewTextBoxColumn.ReadOnly = true;
            this.results9DataGridViewTextBoxColumn.Visible = false;
            // 
            // results10DataGridViewTextBoxColumn
            // 
            this.results10DataGridViewTextBoxColumn.DataPropertyName = "results10";
            this.results10DataGridViewTextBoxColumn.HeaderText = "results10";
            this.results10DataGridViewTextBoxColumn.Name = "results10DataGridViewTextBoxColumn";
            this.results10DataGridViewTextBoxColumn.ReadOnly = true;
            this.results10DataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "teams";
            this.teamsDataGridViewTextBoxColumn.HeaderText = "teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // teams1DataGridViewTextBoxColumn
            // 
            this.teams1DataGridViewTextBoxColumn.DataPropertyName = "teams1";
            this.teams1DataGridViewTextBoxColumn.HeaderText = "teams1";
            this.teams1DataGridViewTextBoxColumn.Name = "teams1DataGridViewTextBoxColumn";
            this.teams1DataGridViewTextBoxColumn.ReadOnly = true;
            this.teams1DataGridViewTextBoxColumn.Visible = false;
            // 
            // driverBindingSource2
            // 
            this.driverBindingSource2.DataSource = typeof(DADBF1.driver);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // powerengDataGridViewTextBoxColumn
            // 
            this.powerengDataGridViewTextBoxColumn.DataPropertyName = "power_eng";
            this.powerengDataGridViewTextBoxColumn.HeaderText = "power_eng";
            this.powerengDataGridViewTextBoxColumn.Name = "powerengDataGridViewTextBoxColumn";
            this.powerengDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fueleffDataGridViewTextBoxColumn
            // 
            this.fueleffDataGridViewTextBoxColumn.DataPropertyName = "fuel_eff";
            this.fueleffDataGridViewTextBoxColumn.HeaderText = "fuel_eff";
            this.fueleffDataGridViewTextBoxColumn.Name = "fueleffDataGridViewTextBoxColumn";
            this.fueleffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resourseDataGridViewTextBoxColumn
            // 
            this.resourseDataGridViewTextBoxColumn.DataPropertyName = "resourse";
            this.resourseDataGridViewTextBoxColumn.HeaderText = "resourse";
            this.resourseDataGridViewTextBoxColumn.Name = "resourseDataGridViewTextBoxColumn";
            this.resourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carweightDataGridViewTextBoxColumn
            // 
            this.carweightDataGridViewTextBoxColumn.DataPropertyName = "car_weight";
            this.carweightDataGridViewTextBoxColumn.HeaderText = "car_weight";
            this.carweightDataGridViewTextBoxColumn.Name = "carweightDataGridViewTextBoxColumn";
            this.carweightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamsDataGridViewTextBoxColumn1
            // 
            this.teamsDataGridViewTextBoxColumn1.DataPropertyName = "teams";
            this.teamsDataGridViewTextBoxColumn1.HeaderText = "teams";
            this.teamsDataGridViewTextBoxColumn1.Name = "teamsDataGridViewTextBoxColumn1";
            this.teamsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.teamsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // teams1DataGridViewTextBoxColumn1
            // 
            this.teams1DataGridViewTextBoxColumn1.DataPropertyName = "teams1";
            this.teams1DataGridViewTextBoxColumn1.HeaderText = "teams1";
            this.teams1DataGridViewTextBoxColumn1.Name = "teams1DataGridViewTextBoxColumn1";
            this.teams1DataGridViewTextBoxColumn1.ReadOnly = true;
            this.teams1DataGridViewTextBoxColumn1.Visible = false;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(DADBF1.car);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(DADBF1.driver);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(DADBF1.team);
            // 
            // driverBindingSource1
            // 
            this.driverBindingSource1.DataSource = typeof(DADBF1.driver);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 434);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.seasonLbl);
            this.Controls.Add(this.loggedUsernameLbl);
            this.Controls.Add(this.loggedLbl);
            this.Controls.Add(this.dataBaseTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataBase";
            this.dataBaseTabs.ResumeLayout(false);
            this.teamPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView1)).EndInit();
            this.driversPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            this.carsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dataBaseTabs;
        private System.Windows.Forms.TabPage teamPage;
        private System.Windows.Forms.TabPage driversPage;
        private System.Windows.Forms.Label loggedLbl;
        private System.Windows.Forms.Label loggedUsernameLbl;
        private System.Windows.Forms.Label seasonLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView teamsDataGridView1;
        private System.Windows.Forms.TabPage carsPage;
        private System.Windows.Forms.TabPage racesPage;
        private System.Windows.Forms.Button teamsAddBtn;
        private System.Windows.Forms.Button teamsShowBtn;
        private System.Windows.Forms.DataGridView driversDataGridView;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.Button driversAddBtn;
        private System.Windows.Forms.Button driversShowBtn;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.BindingSource driverBindingSource1;
        private System.Windows.Forms.BindingSource driverBindingSource2;
        private System.Windows.Forms.Button carsAddBtn;
        private System.Windows.Forms.Button carsShowBtn;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn podiumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trophiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn results10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teams1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn driverEdit;
        private System.Windows.Forms.DataGridViewButtonColumn driverDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerengDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueleffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teams1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn carEdit;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}