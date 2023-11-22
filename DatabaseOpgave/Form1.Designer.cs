namespace DatabaseOpgave
{
    partial class Form1
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
            this.FacilityIdLbl = new System.Windows.Forms.Label();
            this.HotelNoLbl = new System.Windows.Forms.Label();
            this.FacilityNameLbl = new System.Windows.Forms.Label();
            this.txtFacilityId = new System.Windows.Forms.TextBox();
            this.txtHotelNo = new System.Windows.Forms.TextBox();
            this.txtFacilityName = new System.Windows.Forms.TextBox();
            this.InsertFacilityBtn = new System.Windows.Forms.Button();
            this.UpdateFacilityBtn = new System.Windows.Forms.Button();
            this.DeleteFacilityBtn = new System.Windows.Forms.Button();
            this.ShowAllFacilityBtn = new System.Windows.Forms.Button();
            this.ExitFacilityBtn = new System.Windows.Forms.Button();
            this.txtFindBar = new System.Windows.Forms.TextBox();
            this.FindBtn = new System.Windows.Forms.Button();
            this.dataGridViewFacility = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // FacilityIdLbl
            // 
            this.FacilityIdLbl.AutoSize = true;
            this.FacilityIdLbl.Location = new System.Drawing.Point(37, 43);
            this.FacilityIdLbl.Name = "FacilityIdLbl";
            this.FacilityIdLbl.Size = new System.Drawing.Size(73, 20);
            this.FacilityIdLbl.TabIndex = 10;
            this.FacilityIdLbl.Text = "Facility id";
            // 
            // HotelNoLbl
            // 
            this.HotelNoLbl.AutoSize = true;
            this.HotelNoLbl.Location = new System.Drawing.Point(37, 116);
            this.HotelNoLbl.Name = "HotelNoLbl";
            this.HotelNoLbl.Size = new System.Drawing.Size(71, 20);
            this.HotelNoLbl.TabIndex = 11;
            this.HotelNoLbl.Text = "Hotel No";
            // 
            // FacilityNameLbl
            // 
            this.FacilityNameLbl.AutoSize = true;
            this.FacilityNameLbl.Location = new System.Drawing.Point(37, 78);
            this.FacilityNameLbl.Name = "FacilityNameLbl";
            this.FacilityNameLbl.Size = new System.Drawing.Size(103, 20);
            this.FacilityNameLbl.TabIndex = 12;
            this.FacilityNameLbl.Text = "Facility Name";
            // 
            // txtFacilityId
            // 
            this.txtFacilityId.Location = new System.Drawing.Point(144, 37);
            this.txtFacilityId.Name = "txtFacilityId";
            this.txtFacilityId.Size = new System.Drawing.Size(100, 26);
            this.txtFacilityId.TabIndex = 13;
            // 
            // txtHotelNo
            // 
            this.txtHotelNo.Location = new System.Drawing.Point(144, 113);
            this.txtHotelNo.Name = "txtHotelNo";
            this.txtHotelNo.Size = new System.Drawing.Size(100, 26);
            this.txtHotelNo.TabIndex = 14;
            // 
            // txtFacilityName
            // 
            this.txtFacilityName.Location = new System.Drawing.Point(144, 75);
            this.txtFacilityName.Name = "txtFacilityName";
            this.txtFacilityName.Size = new System.Drawing.Size(100, 26);
            this.txtFacilityName.TabIndex = 15;
            // 
            // InsertFacilityBtn
            // 
            this.InsertFacilityBtn.Location = new System.Drawing.Point(43, 154);
            this.InsertFacilityBtn.Name = "InsertFacilityBtn";
            this.InsertFacilityBtn.Size = new System.Drawing.Size(99, 33);
            this.InsertFacilityBtn.TabIndex = 16;
            this.InsertFacilityBtn.Text = "Insert";
            this.InsertFacilityBtn.Click += new System.EventHandler(this.InsertFacilityBtn_Click);
            // 
            // UpdateFacilityBtn
            // 
            this.UpdateFacilityBtn.Location = new System.Drawing.Point(148, 154);
            this.UpdateFacilityBtn.Name = "UpdateFacilityBtn";
            this.UpdateFacilityBtn.Size = new System.Drawing.Size(96, 33);
            this.UpdateFacilityBtn.TabIndex = 17;
            this.UpdateFacilityBtn.Text = "Update";
            this.UpdateFacilityBtn.UseVisualStyleBackColor = true;
            this.UpdateFacilityBtn.Click += new System.EventHandler(this.UpdateFacilityBtn_Click);
            // 
            // DeleteFacilityBtn
            // 
            this.DeleteFacilityBtn.Location = new System.Drawing.Point(43, 193);
            this.DeleteFacilityBtn.Name = "DeleteFacilityBtn";
            this.DeleteFacilityBtn.Size = new System.Drawing.Size(99, 29);
            this.DeleteFacilityBtn.TabIndex = 18;
            this.DeleteFacilityBtn.Text = "Delete";
            this.DeleteFacilityBtn.UseVisualStyleBackColor = true;
            this.DeleteFacilityBtn.Click += new System.EventHandler(this.DeleteFacilityBtn_Click);
            // 
            // ShowAllFacilityBtn
            // 
            this.ShowAllFacilityBtn.Location = new System.Drawing.Point(148, 193);
            this.ShowAllFacilityBtn.Name = "ShowAllFacilityBtn";
            this.ShowAllFacilityBtn.Size = new System.Drawing.Size(96, 29);
            this.ShowAllFacilityBtn.TabIndex = 19;
            this.ShowAllFacilityBtn.Text = "Show all";
            this.ShowAllFacilityBtn.UseVisualStyleBackColor = true;
            this.ShowAllFacilityBtn.Click += new System.EventHandler(this.ShowAllFacilityBtn_Click);
            // 
            // ExitFacilityBtn
            // 
            this.ExitFacilityBtn.Location = new System.Drawing.Point(43, 228);
            this.ExitFacilityBtn.Name = "ExitFacilityBtn";
            this.ExitFacilityBtn.Size = new System.Drawing.Size(99, 30);
            this.ExitFacilityBtn.TabIndex = 20;
            this.ExitFacilityBtn.Text = "Exit";
            this.ExitFacilityBtn.UseVisualStyleBackColor = true;
            this.ExitFacilityBtn.Click += new System.EventHandler(this.ExitFacilityBtn_Click);
            // 
            // txtFindBar
            // 
            this.txtFindBar.Location = new System.Drawing.Point(259, 37);
            this.txtFindBar.Name = "txtFindBar";
            this.txtFindBar.Size = new System.Drawing.Size(733, 26);
            this.txtFindBar.TabIndex = 21;
            this.txtFindBar.TextChanged += new System.EventHandler(this.txtFindBar_TextChanged);
            // 
            // FindBtn
            // 
            this.FindBtn.Location = new System.Drawing.Point(1020, 37);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(96, 26);
            this.FindBtn.TabIndex = 22;
            this.FindBtn.Text = "Find";
            // 
            // dataGridViewFacility
            // 
            this.dataGridViewFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacility.Location = new System.Drawing.Point(259, 75);
            this.dataGridViewFacility.Name = "dataGridViewFacility";
            this.dataGridViewFacility.RowHeadersWidth = 62;
            this.dataGridViewFacility.RowTemplate.Height = 28;
            this.dataGridViewFacility.Size = new System.Drawing.Size(857, 322);
            this.dataGridViewFacility.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 450);
            this.Controls.Add(this.dataGridViewFacility);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.txtFindBar);
            this.Controls.Add(this.ExitFacilityBtn);
            this.Controls.Add(this.ShowAllFacilityBtn);
            this.Controls.Add(this.DeleteFacilityBtn);
            this.Controls.Add(this.UpdateFacilityBtn);
            this.Controls.Add(this.InsertFacilityBtn);
            this.Controls.Add(this.txtFacilityName);
            this.Controls.Add(this.txtHotelNo);
            this.Controls.Add(this.txtFacilityId);
            this.Controls.Add(this.FacilityNameLbl);
            this.Controls.Add(this.HotelNoLbl);
            this.Controls.Add(this.FacilityIdLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacilityIdLbl;
        private System.Windows.Forms.Label HotelNoLbl;
        private System.Windows.Forms.Label FacilityNameLbl;
        private System.Windows.Forms.TextBox txtFacilityId;
        private System.Windows.Forms.TextBox txtHotelNo;
        private System.Windows.Forms.TextBox txtFacilityName;
        private System.Windows.Forms.Button InsertFacilityBtn;
        private System.Windows.Forms.Button UpdateFacilityBtn;
        private System.Windows.Forms.Button DeleteFacilityBtn;
        private System.Windows.Forms.Button ShowAllFacilityBtn;
        private System.Windows.Forms.Button ExitFacilityBtn;
        private System.Windows.Forms.TextBox txtFindBar;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.DataGridView dataGridViewFacility;
    }
}

