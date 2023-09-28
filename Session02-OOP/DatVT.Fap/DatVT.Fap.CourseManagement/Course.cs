using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.CourseManagement
{
    /// <summary>
    /// lưu tên thông tin của mỗi môn học ỏ trường 3 chữ
    /// </summary>
    internal class Course
    {
        //3 cách để lưu info: _back field như java
        //                    _back field get set ngắn gọn - Full Property
        //                    Auto property

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        //lười và new linh hoạt, thì ko làm ctor nào luôn
        //new(){Property = value, ...}

        //hàm in thông tin môn học

        public void PrintCourseInfo()
        {
            Console.WriteLine("|{0}| |{1}| |{2}| |{3}|", Id, Name, Description, Credits);
            //Console.WriteLine($"|{Id}||{Name}||{Description}||{Credits}|");
            //Console.WriteLine("Id: " + Id +
            //    "Name: " + Name +
            //     "Desc: " + Description +
            //    "Credits" + Credits);
        }

        //mình là con của Object và mình có ý định làm lại hàm 
        //ToString() theo cách của mình
        //bên T chỉ việc .ToString() để đảm bảo mọi object
        //đều có hàm này.
        public override string? ToString()
        {
            //return base.ToString();
            //class.System Object

            string courseInfo = $"|{Id}||{Name}||{Description}||{Credits}|";
            return courseInfo;
        }
    }

}
