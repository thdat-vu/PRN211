namespace DatVT.FAP.StudentMgt
{
    partial class StudentListForm
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
            btnExit = new Button();
            dlgOpenFile = new OpenFileDialog();
            btnImage = new Button();
            pictAvatar = new PictureBox();
            lblFilename = new Label();
            pnlImage = new Panel();
            dgvStudentsList = new DataGridView();
            btnSayHello = new Button();
            btnLoadData = new Button();
            lblId = new Label();
            lblName = new Label();
            lblAddress = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            grpInfo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentsList).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(330, 109);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += SayGoodBye;
            // 
            // dlgOpenFile
            // 
            dlgOpenFile.Filter = "JPEG files |*.jpg;*.jpeg|PNG files|*.png";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(149, 227);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(94, 29);
            btnImage.TabIndex = 2;
            btnImage.Text = "True Image";
            btnImage.UseCompatibleTextRendering = true;
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += OpenImage;
            // 
            // pictAvatar
            // 
            pictAvatar.Location = new Point(10, 11);
            pictAvatar.Margin = new Padding(3, 4, 3, 4);
            pictAvatar.Name = "pictAvatar";
            pictAvatar.Size = new Size(387, 205);
            pictAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictAvatar.TabIndex = 3;
            pictAvatar.TabStop = false;
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new Point(330, 236);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(58, 20);
            lblFilename.TabIndex = 4;
            lblFilename.Text = "Image: ";
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.Controls.Add(pictAvatar);
            pnlImage.Location = new Point(172, 307);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(396, 198);
            pnlImage.TabIndex = 5;
            // 
            // dgvStudentsList
            // 
            dgvStudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentsList.Location = new Point(602, 282);
            dgvStudentsList.Name = "dgvStudentsList";
            dgvStudentsList.RowHeadersWidth = 51;
            dgvStudentsList.RowTemplate.Height = 29;
            dgvStudentsList.Size = new Size(538, 207);
            dgvStudentsList.TabIndex = 6;
            dgvStudentsList.SelectionChanged += ShowStudent;
            // 
            // btnSayHello
            // 
            btnSayHello.Location = new Point(149, 109);
            btnSayHello.Name = "btnSayHello";
            btnSayHello.Size = new Size(94, 29);
            btnSayHello.TabIndex = 0;
            btnSayHello.Text = "Say Hello";
            btnSayHello.UseVisualStyleBackColor = true;
            btnSayHello.Click += SayHello;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(602, 109);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(94, 29);
            btnLoadData.TabIndex = 7;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(740, 118);
            lblId.Name = "lblId";
            lblId.Size = new Size(31, 20);
            lblId.TabIndex = 8;
            lblId.Text = "ID: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(740, 166);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Name: ";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(740, 215);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 10;
            lblAddress.Text = "Address: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(830, 115);
            txtId.Name = "txtId";
            txtId.Size = new Size(166, 27);
            txtId.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(830, 166);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 27);
            txtName.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(830, 212);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 27);
            txtAddress.TabIndex = 13;
            // 
            // grpInfo
            // 
            grpInfo.Location = new Point(720, 85);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(322, 181);
            grpInfo.TabIndex = 14;
            grpInfo.TabStop = false;
            grpInfo.Text = "Student Info";
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 682);
            Controls.Add(pnlImage);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(btnLoadData);
            Controls.Add(dgvStudentsList);
            Controls.Add(lblFilename);
            Controls.Add(btnImage);
            Controls.Add(btnExit);
            Controls.Add(btnSayHello);
            Controls.Add(grpInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentListForm";
            Text = "Student List";
            Click += SayHello;
            ((System.ComponentModel.ISupportInitialize)pictAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private OpenFileDialog dlgOpenFile;
        private Button btnImage;
        private PictureBox pictAvatar;
        private Label lblFilename;
        private Panel pnlImage;
        private DataGridView dgvStudentsList;
        private Button btnSayHello;
        private Button btnLoadData;
        private Label lblId;
        private Label lblName;
        private Label lblAddress;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAddress;
        private GroupBox grpInfo;
    }
}