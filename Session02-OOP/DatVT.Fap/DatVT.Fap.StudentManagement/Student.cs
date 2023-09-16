using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.StudentManagement
{
    internal class Student
    {
        //nếu ko ghi public , private thì mặc định là private 
        //những biến mà dùng để lưu ionffo của 1 object thì gọi là
        //instance variable - C# còn gọi là backed-field, data field
        string _id;
        string _name;
        int _yob;
        string _email;



        //nếu khi ta tạo 1 sv mà ko gán info gì cả, các field này mang giá trị default
        // số -> 0, bool -> false , object -> null

        public Student(string id, string name, int yob, string email)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _email = email;
        }

        //public string GetId()
        //{
        //    return _id;
        //} // style Java



        public string GetId() => _id;
        //expresion body, khi hàm chỉ có duy nhất 1 lệnh, ta dẹp luôn return, {}, nối lệnh với tên hàm qua dấu =>
        //đây ko phải lambda

        //public void SetName(string name) 
        //{ 
        //    _name = name; 
        //}

        public void SetName(string name) => _name = name;
        //public void ShowProfile() 
        //{
        //    Console.WriteLine("ID: " + _id + "| Name " + _name + "|YOB " + _yob);

        //}

        //chuyển thành expression body
        public void ShowProfile() => Console.WriteLine("ID: " + _id + "| Name " + _name + "| YOB " + _yob);

    }
}
