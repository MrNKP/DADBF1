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
            this.driversPage = new System.Windows.Forms.TabPage();
            this.loggedLbl = new System.Windows.Forms.Label();
            this.loggedUsernameLbl = new System.Windows.Forms.Label();
            this.seasonLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carsPage = new System.Windows.Forms.TabPage();
            this.racesPage = new System.Windows.Forms.TabPage();
            this.teamsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamsShowBtn = new System.Windows.Forms.Button();
            this.teamsAddBtn = new System.Windows.Forms.Button();
            this.driversShowBtn = new System.Windows.Forms.Button();
            this.driversAddBtn = new System.Windows.Forms.Button();
            this.driversDataGridView = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trophiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.teamsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teams1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseTabs.SuspendLayout();
            this.teamPage.SuspendLayout();
            this.driversPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
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
            // carsPage
            // 
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
            // teamsDataGridView1
            // 
            this.teamsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsDataGridView1.Location = new System.Drawing.Point(6, 6);
            this.teamsDataGridView1.Name = "teamsDataGridView1";
            this.teamsDataGridView1.RowTemplate.Height = 24;
            this.teamsDataGridView1.Size = new System.Drawing.Size(1226, 321);
            this.teamsDataGridView1.TabIndex = 0;
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
            // teamsAddBtn
            // 
            this.teamsAddBtn.Location = new System.Drawing.Point(1238, 58);
            this.teamsAddBtn.Name = "teamsAddBtn";
            this.teamsAddBtn.Size = new System.Drawing.Size(116, 46);
            this.teamsAddBtn.TabIndex = 2;
            this.teamsAddBtn.Text = "Add";
            this.teamsAddBtn.UseVisualStyleBackColor = true;
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
            // driversDataGridView
            // 
            this.driversDataGridView.AutoGenerateColumns = false;
            this.driversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.trophiesDataGridViewTextBoxColumn,
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
            this.teamsDataGridViewTextBoxColumn,
            this.teams1DataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.driversDataGridView.DataSource = this.driverBindingSource;
            this.driversDataGridView.Location = new System.Drawing.Point(7, 7);
            this.driversDataGridView.Name = "driversDataGridView";
            this.driversDataGridView.RowTemplate.Height = 24;
            this.driversDataGridView.Size = new System.Drawing.Size(1226, 320);
            this.driversDataGridView.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "FamilyName";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // trophiesDataGridViewTextBoxColumn
            // 
            this.trophiesDataGridViewTextBoxColumn.DataPropertyName = "trophies";
            this.trophiesDataGridViewTextBoxColumn.HeaderText = "Trophies";
            this.trophiesDataGridViewTextBoxColumn.Name = "trophiesDataGridViewTextBoxColumn";
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            // 
            // resultsDataGridViewTextBoxColumn
            // 
            this.resultsDataGridViewTextBoxColumn.DataPropertyName = "results";
            this.resultsDataGridViewTextBoxColumn.HeaderText = "results";
            this.resultsDataGridViewTextBoxColumn.Name = "resultsDataGridViewTextBoxColumn";
            this.resultsDataGridViewTextBoxColumn.Visible = false;
            // 
            // results1DataGridViewTextBoxColumn
            // 
            this.results1DataGridViewTextBoxColumn.DataPropertyName = "results1";
            this.results1DataGridViewTextBoxColumn.HeaderText = "results1";
            this.results1DataGridViewTextBoxColumn.Name = "results1DataGridViewTextBoxColumn";
            this.results1DataGridViewTextBoxColumn.Visible = false;
            // 
            // results2DataGridViewTextBoxColumn
            // 
            this.results2DataGridViewTextBoxColumn.DataPropertyName = "results2";
            this.results2DataGridViewTextBoxColumn.HeaderText = "results2";
            this.results2DataGridViewTextBoxColumn.Name = "results2DataGridViewTextBoxColumn";
            this.results2DataGridViewTextBoxColumn.Visible = false;
            // 
            // results3DataGridViewTextBoxColumn
            // 
            this.results3DataGridViewTextBoxColumn.DataPropertyName = "results3";
            this.results3DataGridViewTextBoxColumn.HeaderText = "results3";
            this.results3DataGridViewTextBoxColumn.Name = "results3DataGridViewTextBoxColumn";
            this.results3DataGridViewTextBoxColumn.Visible = false;
            // 
            // results4DataGridViewTextBoxColumn
            // 
            this.results4DataGridViewTextBoxColumn.DataPropertyName = "results4";
            this.results4DataGridViewTextBoxColumn.HeaderText = "results4";
            this.results4DataGridViewTextBoxColumn.Name = "results4DataGridViewTextBoxColumn";
            this.results4DataGridViewTextBoxColumn.Visible = false;
            // 
            // results5DataGridViewTextBoxColumn
            // 
            this.results5DataGridViewTextBoxColumn.DataPropertyName = "results5";
            this.results5DataGridViewTextBoxColumn.HeaderText = "results5";
            this.results5DataGridViewTextBoxColumn.Name = "results5DataGridViewTextBoxColumn";
            this.results5DataGridViewTextBoxColumn.Visible = false;
            // 
            // results6DataGridViewTextBoxColumn
            // 
            this.results6DataGridViewTextBoxColumn.DataPropertyName = "results6";
            this.results6DataGridViewTextBoxColumn.HeaderText = "results6";
            this.results6DataGridViewTextBoxColumn.Name = "results6DataGridViewTextBoxColumn";
            this.results6DataGridViewTextBoxColumn.Visible = false;
            // 
            // results7DataGridViewTextBoxColumn
            // 
            this.results7DataGridViewTextBoxColumn.DataPropertyName = "results7";
            this.results7DataGridViewTextBoxColumn.HeaderText = "results7";
            this.results7DataGridViewTextBoxColumn.Name = "results7DataGridViewTextBoxColumn";
            this.results7DataGridViewTextBoxColumn.Visible = false;
            // 
            // results8DataGridViewTextBoxColumn
            // 
            this.results8DataGridViewTextBoxColumn.DataPropertyName = "results8";
            this.results8DataGridViewTextBoxColumn.HeaderText = "results8";
            this.results8DataGridViewTextBoxColumn.Name = "results8DataGridViewTextBoxColumn";
            this.results8DataGridViewTextBoxColumn.Visible = false;
            // 
            // results9DataGridViewTextBoxColumn
            // 
            this.results9DataGridViewTextBoxColumn.DataPropertyName = "results9";
            this.results9DataGridViewTextBoxColumn.HeaderText = "results9";
            this.results9DataGridViewTextBoxColumn.Name = "results9DataGridViewTextBoxColumn";
            this.results9DataGridViewTextBoxColumn.Visible = false;
            // 
            // teamsDataGridViewTextBoxColumn
            // 
            this.teamsDataGridViewTextBoxColumn.DataPropertyName = "teams";
            this.teamsDataGridViewTextBoxColumn.HeaderText = "teams";
            this.teamsDataGridViewTextBoxColumn.Name = "teamsDataGridViewTextBoxColumn";
            this.teamsDataGridViewTextBoxColumn.Visible = false;
            // 
            // teams1DataGridViewTextBoxColumn
            // 
            this.teams1DataGridViewTextBoxColumn.DataPropertyName = "teams1";
            this.teams1DataGridViewTextBoxColumn.HeaderText = "teams1";
            this.teams1DataGridViewTextBoxColumn.Name = "teams1DataGridViewTextBoxColumn";
            this.teams1DataGridViewTextBoxColumn.Visible = false;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataSource = typeof(DADBF1.driver);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(DADBF1.team);
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
            this.driversPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trophiesDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn teamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teams1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}