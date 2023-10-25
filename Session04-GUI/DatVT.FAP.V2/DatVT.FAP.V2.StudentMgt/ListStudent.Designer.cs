namespace DatVT.FAP.V2.StudentMgt
{
    partial class ListStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudentList = new DataGridView();
            lblID = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            lblGpa = new Label();
            txtGpa = new TextBox();
            txtSearch = new TextBox();
            dvgSearchResult = new DataGridView();
            grpSearch = new GroupBox();
            lblStudentMgt = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgSearchResult).BeginInit();
            grpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(564, 144);
            dgvStudentList.Margin = new Padding(3, 4, 3, 4);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowHeadersWidth = 51;
            dgvStudentList.RowTemplate.Height = 25;
            dgvStudentList.Size = new Size(455, 292);
            dgvStudentList.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(153, 144);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(153, 188);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(149, 237);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtID
            // 
            txtID.Location = new Point(220, 144);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 188);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(220, 237);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(114, 27);
            txtAddress.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 370);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += AddAStudent;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(208, 370);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateAStudent;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(328, 370);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += DeleteAStudent;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 255, 192);
            btnSearch.Location = new Point(86, 452);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += SearchStudents;
            // 
            // lblGpa
            // 
            lblGpa.AutoSize = true;
            lblGpa.Location = new Point(153, 296);
            lblGpa.Name = "lblGpa";
            lblGpa.Size = new Size(39, 20);
            lblGpa.TabIndex = 11;
            lblGpa.Text = "GPA:";
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(220, 296);
            txtGpa.Margin = new Padding(3, 4, 3, 4);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(114, 27);
            txtGpa.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(132, 29);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 27);
            txtSearch.TabIndex = 9;
            // 
            // dvgSearchResult
            // 
            dvgSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSearchResult.Location = new Point(86, 516);
            dvgSearchResult.Margin = new Padding(3, 4, 3, 4);
            dvgSearchResult.Name = "dvgSearchResult";
            dvgSearchResult.RowHeadersWidth = 51;
            dvgSearchResult.RowTemplate.Height = 25;
            dvgSearchResult.Size = new Size(373, 139);
            dvgSearchResult.TabIndex = 9;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Location = new Point(88, 427);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(350, 80);
            grpSearch.TabIndex = 7;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search";
            // 
            // lblStudentMgt
            // 
            lblStudentMgt.AutoSize = true;
            lblStudentMgt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentMgt.Location = new Point(116, 30);
            lblStudentMgt.Name = "lblStudentMgt";
            lblStudentMgt.Size = new Size(324, 41);
            lblStudentMgt.TabIndex = 12;
            lblStudentMgt.Text = "Student Management";
            // 
            // ListStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 723);
            Controls.Add(lblStudentMgt);
            Controls.Add(dvgSearchResult);
            Controls.Add(txtGpa);
            Controls.Add(lblGpa);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(dgvStudentList);
            Controls.Add(grpSearch);
            Name = "ListStudent";
            Text = "List Of Student";
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgSearchResult).EndInit();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentList;
        private Label lblID;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label lblGpa;
        private TextBox txtGpa;
        private TextBox txtSearch;
        private DataGridView dvgSearchResult;
        private GroupBox grpSearch;
        private Label lblStudentMgt;
    }
}