namespace DatVT.FAP.StudentMgt
{
    public partial class StudentListForm : Form
    {
        List<Student> _ds = new List<Student>();
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

            _ds.Add(new Student() { Id = "SE1", Name = "An", Address = "Dương đông" });
            _ds.Add(new Student() { Id = "SE2", Name = "Dương", Address = "Tân Bình" });
            _ds.Add(new Student() { Id = "SE3", Name = "Dũng", Address = "Tân An" });
            dgvStudentsList.DataSource = _ds;
        }

        private void ShowStudent(object sender, EventArgs e)
        {
            //ta sẽ xài các hàm, thuộc tính dgv qua dấu chấm.
            //toàn bộ những gì trên form đêu là các biên object trỏ vùng new
            //DataGridView dgv = new DataGridView();
            //                  dgv.DataSource = danh sách này
            //                  dgv.Click += chừa chỗ hàm ai đó
            //                  dgv.Click thì làm gì, gọi hàm này
            //                  xài các chấm khác để biết dòng nào đc chọn, lấy từng cell
            if (dgvStudentsList.SelectedRows.Count > 0)
            {
                //lấy ra dòng vừa chọn, trích từng cell ra 
                DataGridViewRow selectedRow = dgvStudentsList.SelectedRows[0];
                txtId.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();//cùng 1 dòng, từ trái sang phải qua là cell 1
                txtAddress.Text = selectedRow.Cells[2].Value.ToString();//cùng 1, từ trái sang phải qua là cell 2

            }
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            Student x = new Student();
            x.Id = txtId.Text;
            x.Name = txtName.Text;
            x.Address = txtAddress.Text;
            _ds.Add(x);
            //refresh cái grid
            dgvStudentsList.DataSource = null; //clear grid
            dgvStudentsList.DataSource = _ds;
        }

        //private void SearchStudents(object sender, EventArgs e)
        //{
        //   var r = _ds.Where(CheckStudentWhereDuong).ToList() ; // trả về 1 list thực sự
        //    //trả về 1 list
        //    dgvResult.DataSource = null;
        //    dgvResult.DataSource = r;

        //}
        private bool CheckStudentWhereDuong(Student xxx) => xxx.Name == "Dương";


        private void SearchStudents(object sender, EventArgs e)
        {
            //var r = _ds.Where((xxx) => xxx.Name == txtKeyword.Text).ToList(); // trả về 1 list thực sự
            var r = _ds.Where((xxx) => xxx.Name.ToLower().Contains(txtKeyword.Text.ToLower())
            ||xxx.Address.ToLower().Contains(txtKeyword.Text.ToLower())).ToList();
            //trả về 1 list
            dgvResult.DataSource = null;
            dgvResult.DataSource = r;
        }
    }
}