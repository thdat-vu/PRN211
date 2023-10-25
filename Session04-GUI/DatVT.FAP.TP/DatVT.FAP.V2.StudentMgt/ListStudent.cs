using DatVT.FAP.V2.Repositories;
namespace DatVT.FAP.V2.StudentMgt;


public partial class ListStudent : Form
{
    private IStudentRepository _repo;//tuyệt đỉnh thú cưng

    //xài kho dữ liệu lấy từ SQLServer
    public ListStudent()
    {

        InitializeComponent();
        InitializeStudentRepository();
    }

    private void InitializeStudentRepository()
    {
        _repo = new StudentRepositorySqlServer();
        dgvStudentList.DataSource = _repo.GetAll();
    }
    private void DeleteAStudent(object sender, EventArgs e)
    {

    }

    private void SearchStudents(object sender, EventArgs e)
    {
        dvgSearchResult.DataSource = null;//xóa lưới
        dvgSearchResult.DataSource = _repo.GetAll();

    }

    private void AddAStudent(object sender, EventArgs e)
    {
        Student x = new Student()
        {
            Id = txtID.Text,
            Name = txtName.Text,
            Address = txtAddress.Text,
            Gpa = double.Parse(txtGpa.Text),
        };
        _repo.Add(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repo.GetAll();
    }

    private void UpdateAStudent(object sender, EventArgs e)
    {
        Student x = new Student()
        {
            Id = txtID.Text,
            Name = txtName.Text,
            Address = txtAddress.Text,
            Gpa = double.Parse(txtGpa.Text),
        };
        _repo.Update(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repo.GetAll();
    }

    private void ViewAStudent(object sender, EventArgs e)
    {
        if(dgvStudentList.SelectedRows.Count > 0)
        {
            DataGridViewRow row = dgvStudentList.SelectedRows[0];
            txtID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtGpa.Text = row.Cells[3].Value.ToString();
        }
    }
}