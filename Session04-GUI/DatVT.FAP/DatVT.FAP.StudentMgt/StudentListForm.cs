namespace DatVT.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void SayHello(object sender, EventArgs e)
        {
            MessageBox.Show("This 1st message that comes from VS2022. Welcome to winforms",
                "Notification!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        }

        private void SayGoodBye(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Goodbye. Are you sure? ",
                 "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void OpenImage(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(dlgOpenFile.FileName);
                lblFilename.Text = "File Image: " + dlgOpenFile.FileName;
                pictAvatar.Image = new Bitmap(dlgOpenFile.FileName);
            }
        }



        private void LoadData(object sender, EventArgs e)
        {
            List<Student> ds = new List<Student>();
            ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dương đông" });
            ds.Add(new Student() { Id = "SE2", Name = "Dương", Address = "Tân Bình" });
            ds.Add(new Student() { Id = "SE3", Name = "Dũng", Address = "Tân An" });
            dgvStudentsList.DataSource = ds;
        }

        private void ShowStudent(object sender, EventArgs e)
        {
            //ta sẽ xài các hàm, thuộc tính dgv qua dấu chấm.
            //toàn bộ những gì trên form đêu là các biên object trỏ vùng new
            //DataGridView dgv = new DataGridView();
            //                  dgv.DataSource = danh sách này
            //                  dgv.Click += chừa chỗ hàm ai đó
            //                  dgv.Click thì làm gì, gọi hàm nấy
            //                  xài các chấm khác để biết dòng nào đc chọn, lấy từng cell
            if(dgvStudentsList.SelectedRows.Count > 0)
            {

            }
        }
    }
}