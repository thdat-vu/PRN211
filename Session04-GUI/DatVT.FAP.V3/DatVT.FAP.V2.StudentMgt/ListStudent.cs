using DatVT.FAP.V2.Repositories;
namespace DatVT.FAP.V2.StudentMgt;


public partial class ListStudent : Form
{
    //private StudentRepositorySqlserver _repoSqlserver;
    //xài kho dữ liệu lấy từ SQLServer
    private StudentRepositoryMySQL _repositoryMySQL;
    public ListStudent()
    {
        InitializeComponent();
    }

    private void DeleteAStudent(object sender, EventArgs e)
    {
        _repositoryMySQL = new StudentRepositoryMySQL();
    }

    private void SearchStudents(object sender, EventArgs e)
    {
        dvgSearchResult.DataSource = null;//xóa lưới
        dvgSearchResult.DataSource = _repositoryMySQL.GetAllStudents();

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
        _repositoryMySQL.AddAStudent(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repositoryMySQL.GetAllStudents();
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
        _repositoryMySQL.Update(x);

        //refresh grid
        dgvStudentList.DataSource = null; //xóa lưới
        dgvStudentList.DataSource = _repoSqlserver.GetAll();
    }
}