namespace DADBF1
{
    partial class TeamEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamEdit));
            this.teamNameLbl = new System.Windows.Forms.Label();
            this.driver1Lbl = new System.Windows.Forms.Label();
            this.car1Lbl = new System.Windows.Forms.Label();
            this.driver2Lbl = new System.Windows.Forms.Label();
            this.car2Lbl = new System.Windows.Forms.Label();
            this.driver1ComboBox = new System.Windows.Forms.ComboBox();
            this.car1ComboBox = new System.Windows.Forms.ComboBox();
            this.driver2ComboBox = new System.Windows.Forms.ComboBox();
            this.car2ComboBox = new System.Windows.Forms.ComboBox();
            this.teamTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamNameLbl
            // 
            this.teamNameLbl.AutoSize = true;
            this.teamNameLbl.Location = new System.Drawing.Point(12, 16);
            this.teamNameLbl.Name = "teamNameLbl";
            this.teamNameLbl.Size = new System.Drawing.Size(57, 17);
            this.teamNameLbl.TabIndex = 0;
            this.teamNameLbl.Text = "Name : ";
            // 
            // driver1Lbl
            // 
            this.driver1Lbl.AutoSize = true;
            this.driver1Lbl.Location = new System.Drawing.Point(12, 74);
            this.driver1Lbl.Name = "driver1Lbl";
            this.driver1Lbl.Size = new System.Drawing.Size(70, 17);
            this.driver1Lbl.TabIndex = 1;
            this.driver1Lbl.Text = "Driver 1 : ";
            // 
            // car1Lbl
            // 
            this.car1Lbl.AutoSize = true;
            this.car1Lbl.Location = new System.Drawing.Point(219, 74);
            this.car1Lbl.Name = "car1Lbl";
            this.car1Lbl.Size = new System.Drawing.Size(54, 17);
            this.car1Lbl.TabIndex = 2;
            this.car1Lbl.Text = "Car 1 : ";
            // 
            // driver2Lbl
            // 
            this.driver2Lbl.AutoSize = true;
            this.driver2Lbl.Location = new System.Drawing.Point(12, 162);
            this.driver2Lbl.Name = "driver2Lbl";
            this.driver2Lbl.Size = new System.Drawing.Size(66, 17);
            this.driver2Lbl.TabIndex = 3;
            this.driver2Lbl.Text = "Driver 2 :";
            // 
            // car2Lbl
            // 
            this.car2Lbl.AutoSize = true;
            this.car2Lbl.Location = new System.Drawing.Point(219, 162);
            this.car2Lbl.Name = "car2Lbl";
            this.car2Lbl.Size = new System.Drawing.Size(54, 17);
            this.car2Lbl.TabIndex = 4;
            this.car2Lbl.Text = "Car 2 : ";
            // 
            // driver1ComboBox
            // 
            this.driver1ComboBox.FormattingEnabled = true;
            this.driver1ComboBox.Location = new System.Drawing.Point(15, 94);
            this.driver1ComboBox.Name = "driver1ComboBox";
            this.driver1ComboBox.Size = new System.Drawing.Size(201, 24);
            this.driver1ComboBox.TabIndex = 5;
            // 
            // car1ComboBox
            // 
            this.car1ComboBox.FormattingEnabled = true;
            this.car1ComboBox.Location = new System.Drawing.Point(222, 94);
            this.car1ComboBox.Name = "car1ComboBox";
            this.car1ComboBox.Size = new System.Drawing.Size(202, 24);
            this.car1ComboBox.TabIndex = 6;
            // 
            // driver2ComboBox
            // 
            this.driver2ComboBox.FormattingEnabled = true;
            this.driver2ComboBox.Location = new System.Drawing.Point(15, 182);
            this.driver2ComboBox.Name = "driver2ComboBox";
            this.driver2ComboBox.Size = new System.Drawing.Size(201, 24);
            this.driver2ComboBox.TabIndex = 7;
            // 
            // car2ComboBox
            // 
            this.car2ComboBox.FormattingEnabled = true;
            this.car2ComboBox.Location = new System.Drawing.Point(222, 182);
            this.car2ComboBox.Name = "car2ComboBox";
            this.car2ComboBox.Size = new System.Drawing.Size(202, 24);
            this.car2ComboBox.TabIndex = 8;
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(75, 13);
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.Size = new System.Drawing.Size(349, 22);
            this.teamTextBox.TabIndex = 9;
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(15, 227);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(201, 40);
            this.OkBtn.TabIndex = 10;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(222, 227);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(202, 40);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // TeamEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 282);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.teamTextBox);
            this.Controls.Add(this.car2ComboBox);
            this.Controls.Add(this.driver2ComboBox);
            this.Controls.Add(this.car1ComboBox);
            this.Controls.Add(this.driver1ComboBox);
            this.Controls.Add(this.car2Lbl);
            this.Controls.Add(this.driver2Lbl);
            this.Controls.Add(this.car1Lbl);
            this.Controls.Add(this.driver1Lbl);
            this.Controls.Add(this.teamNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameLbl;
        private System.Windows.Forms.Label driver1Lbl;
        private System.Windows.Forms.Label car1Lbl;
        private System.Windows.Forms.Label driver2Lbl;
        private System.Windows.Forms.Label car2Lbl;
        public System.Windows.Forms.ComboBox driver1ComboBox;
        public System.Windows.Forms.ComboBox car1ComboBox;
        public System.Windows.Forms.ComboBox driver2ComboBox;
        public System.Windows.Forms.ComboBox car2ComboBox;
        public System.Windows.Forms.TextBox teamTextBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}