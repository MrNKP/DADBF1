namespace DADBF1
{
    partial class CarEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEdit));
            this.enginePowerLbl = new System.Windows.Forms.Label();
            this.enginePowerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fuelEffNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resourseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fuelEffLbl = new System.Windows.Forms.Label();
            this.resourseLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enginePowerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelEffNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // enginePowerLbl
            // 
            this.enginePowerLbl.AutoSize = true;
            this.enginePowerLbl.Location = new System.Drawing.Point(12, 9);
            this.enginePowerLbl.Name = "enginePowerLbl";
            this.enginePowerLbl.Size = new System.Drawing.Size(107, 17);
            this.enginePowerLbl.TabIndex = 0;
            this.enginePowerLbl.Text = "Engine Power : ";
            // 
            // enginePowerNumericUpDown
            // 
            this.enginePowerNumericUpDown.Location = new System.Drawing.Point(136, 7);
            this.enginePowerNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.enginePowerNumericUpDown.Name = "enginePowerNumericUpDown";
            this.enginePowerNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.enginePowerNumericUpDown.TabIndex = 1;
            // 
            // fuelEffNumericUpDown
            // 
            this.fuelEffNumericUpDown.DecimalPlaces = 1;
            this.fuelEffNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fuelEffNumericUpDown.Location = new System.Drawing.Point(136, 35);
            this.fuelEffNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fuelEffNumericUpDown.Name = "fuelEffNumericUpDown";
            this.fuelEffNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.fuelEffNumericUpDown.TabIndex = 2;
            this.fuelEffNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resourseNumericUpDown
            // 
            this.resourseNumericUpDown.Location = new System.Drawing.Point(136, 63);
            this.resourseNumericUpDown.Name = "resourseNumericUpDown";
            this.resourseNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.resourseNumericUpDown.TabIndex = 3;
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.DecimalPlaces = 1;
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.weightNumericUpDown.Location = new System.Drawing.Point(136, 91);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.weightNumericUpDown.TabIndex = 4;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // fuelEffLbl
            // 
            this.fuelEffLbl.AutoSize = true;
            this.fuelEffLbl.Location = new System.Drawing.Point(12, 37);
            this.fuelEffLbl.Name = "fuelEffLbl";
            this.fuelEffLbl.Size = new System.Drawing.Size(68, 17);
            this.fuelEffLbl.TabIndex = 5;
            this.fuelEffLbl.Text = "Fuel Eff : ";
            // 
            // resourseLbl
            // 
            this.resourseLbl.AutoSize = true;
            this.resourseLbl.Location = new System.Drawing.Point(12, 65);
            this.resourseLbl.Name = "resourseLbl";
            this.resourseLbl.Size = new System.Drawing.Size(81, 17);
            this.resourseLbl.TabIndex = 6;
            this.resourseLbl.Text = "Resourse : ";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(12, 93);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(64, 17);
            this.weightLbl.TabIndex = 7;
            this.weightLbl.Text = "Weight : ";
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(13, 125);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(243, 42);
            this.OkBtn.TabIndex = 8;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(12, 173);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(244, 42);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // CarEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 225);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.resourseLbl);
            this.Controls.Add(this.fuelEffLbl);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.resourseNumericUpDown);
            this.Controls.Add(this.fuelEffNumericUpDown);
            this.Controls.Add(this.enginePowerNumericUpDown);
            this.Controls.Add(this.enginePowerLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            ((System.ComponentModel.ISupportInitialize)(this.enginePowerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelEffNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enginePowerLbl;
        public System.Windows.Forms.NumericUpDown enginePowerNumericUpDown;
        public System.Windows.Forms.NumericUpDown fuelEffNumericUpDown;
        public System.Windows.Forms.NumericUpDown resourseNumericUpDown;
        public System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.Label fuelEffLbl;
        private System.Windows.Forms.Label resourseLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}