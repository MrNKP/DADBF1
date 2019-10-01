namespace DADBF1
{
    partial class DriverAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverAddForm));
            this.familyNameLbl = new System.Windows.Forms.Label();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.experienceTextBox = new System.Windows.Forms.TextBox();
            this.trophiesTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.experienceLbl = new System.Windows.Forms.Label();
            this.trophiesLbl = new System.Windows.Forms.Label();
            this.pointsLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // familyNameLbl
            // 
            this.familyNameLbl.AutoSize = true;
            this.familyNameLbl.Location = new System.Drawing.Point(13, 13);
            this.familyNameLbl.Name = "familyNameLbl";
            this.familyNameLbl.Size = new System.Drawing.Size(97, 17);
            this.familyNameLbl.TabIndex = 0;
            this.familyNameLbl.Text = "Family Name :";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.Location = new System.Drawing.Point(136, 10);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(387, 22);
            this.familyNameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(136, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(387, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // experienceTextBox
            // 
            this.experienceTextBox.Location = new System.Drawing.Point(136, 66);
            this.experienceTextBox.Name = "experienceTextBox";
            this.experienceTextBox.Size = new System.Drawing.Size(387, 22);
            this.experienceTextBox.TabIndex = 3;
            // 
            // trophiesTextBox
            // 
            this.trophiesTextBox.Location = new System.Drawing.Point(136, 94);
            this.trophiesTextBox.Name = "trophiesTextBox";
            this.trophiesTextBox.Size = new System.Drawing.Size(387, 22);
            this.trophiesTextBox.TabIndex = 4;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(136, 122);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(387, 22);
            this.pointsTextBox.TabIndex = 5;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(13, 41);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name :";
            // 
            // experienceLbl
            // 
            this.experienceLbl.AutoSize = true;
            this.experienceLbl.Location = new System.Drawing.Point(13, 69);
            this.experienceLbl.Name = "experienceLbl";
            this.experienceLbl.Size = new System.Drawing.Size(86, 17);
            this.experienceLbl.TabIndex = 7;
            this.experienceLbl.Text = "Experience :";
            // 
            // trophiesLbl
            // 
            this.trophiesLbl.AutoSize = true;
            this.trophiesLbl.Location = new System.Drawing.Point(13, 97);
            this.trophiesLbl.Name = "trophiesLbl";
            this.trophiesLbl.Size = new System.Drawing.Size(72, 17);
            this.trophiesLbl.TabIndex = 8;
            this.trophiesLbl.Text = "Trophies :";
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.Location = new System.Drawing.Point(13, 125);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(55, 17);
            this.pointsLbl.TabIndex = 9;
            this.pointsLbl.Text = "Points :";
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Location = new System.Drawing.Point(13, 150);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(252, 55);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(270, 150);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(252, 55);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // DriverAddForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(532, 214);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.pointsLbl);
            this.Controls.Add(this.trophiesLbl);
            this.Controls.Add(this.experienceLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.trophiesTextBox);
            this.Controls.Add(this.experienceTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(this.familyNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DriverAddForm";
            this.Text = "Add Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label familyNameLbl;
        public System.Windows.Forms.TextBox familyNameTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox experienceTextBox;
        public System.Windows.Forms.TextBox trophiesTextBox;
        public System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label experienceLbl;
        private System.Windows.Forms.Label trophiesLbl;
        private System.Windows.Forms.Label pointsLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
    }
}