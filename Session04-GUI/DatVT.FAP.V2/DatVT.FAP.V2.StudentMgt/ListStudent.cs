using DatVT.FAP.V2.Repositories;
namespace DatVT.FAP.V2.StudentMgt;


public partial class ListStudent : Form
{
    private StudentRepositorySqlserver _repoSqlserver;
    //xài kho dữ liệu lấy từ SQLServer
    public ListStudent()
    {
        InitializeComponent();
    }

    private void DeleteAStudent(object sender, EventArgs e)
    {
        _repoSqlserver = new StudentRepositorySqlserver();
    }

    private void SearchStudents(object sender, EventArgs e)
    {
        dvgSearchResult.DataSource = null;//xóa lưới
        dvgSearchResult.DataSource =

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
        _repoSqlserver.Add(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repoSqlserver.GetAll();
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
        _repoSqlserver.Update(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repoSqlserver.GetAll();
    }
}