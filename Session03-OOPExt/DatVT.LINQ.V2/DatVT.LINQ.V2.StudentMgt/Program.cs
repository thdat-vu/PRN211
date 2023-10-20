namespace DatVT.LINQ.V2.StudentMgt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CheckMyListWithGpa();
            //CheckMyListWithGpaAndYob();
            //GetStudentsByAnyCondition();
            //GetStudentsByAddress();
            SearchStudent();
        }

        static void SearchStudent()
        {
            MyList myList = new MyList();

            List<Student> result = myList.GetStudents(x => x.Name.ToLower().Contains("dương")
            || x.Address.ToLower().Contains("dương")) ;
            Console.WriteLine("The list of the student contains \"Dương\" in Name or Address");
            //for trực tiếp trên kết quả trả về thay vì forr biến r cũng vậy
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
        //hàm lẻ để query sinh viên
        static bool CheckStudentGpa8(Student x)
        {
            if(x.Gpa >= 8)
            {
                return true;
            }
            return false;
        }
        //hàm lẻ query student theo năm sinh và gpa
        //static bool CheckStudentGpa8AndYob2005(Student x)
        //{
        //    if (x.Gpa >= 8 && x.Yob >=2005)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //static bool CheckStudentGpa8AndYob2005(Student x)
        //{
        //    return (x.Gpa >= 8 && x.Yob >= 2005) ;
        //    //đằng nào biêu thức cũng trả về true/false, thì thôi khỏi
        //    //if vì if cũng chỉ để return true, false
        //}
        static bool CheckStudentGpa8AndYob2005(Student x) 
            => x.Gpa >= 8 && x.Yob >= 2005;
        
        static void GetStudentsByAddress()
        {
            MyList myList = new MyList();
            //List<Student> result = myList.GetStudents(x => x.Address == "Bình Dương");
            List<Student> result = myList.GetStudents(x => x.Address == "Bình Dương" || x.Address == "Thanh Đa");
        }
        static void GetStudentsByAnyCondition()
        {
            MyList myList = new MyList();

            List<Student> result = myList.GetStudents(CheckStudentGpa8);
            Console.WriteLine("The list of the student with GPA >=8: ");
            //for trực tiếp trên kết quả trả về thay vì forr biến r cũng vậy
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("The list of the student with GPA >=8 and Yob >= 2005: ");
            foreach (var x in myList.GetStudents(CheckStudentGpa8AndYob2005))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("The list of the studebt with Address = \"Bình Dương\"");
            //foreach (var x in myList.GetStudents(GetStudentsByAddress))
            //{
            //    Console.WriteLine(x);
            //}
        }

        static void CheckMyListWithGpaAndYob()
        {
            MyList myList = new MyList();
            Console.WriteLine("The list of the student with GPA >= 8 and Yob >= 2005: ");
            //for trực tiếp trên kết quả trả về thay vì forr biến r cũng vậy
            foreach (var x in myList.GetStudentsByGpaAndYob())
            {
                Console.WriteLine(x);
            }

        }
        static void CheckMyListWithGpa()
        {
            MyList  myList = new MyList();
            Console.WriteLine("The list of the student with GPA >=8: ");
            //for trực tiếp trên kết quả trả về thay vì forr biến r cũng vậy
            foreach (var x in myList.GetStudentsByGpa()) {
                Console.WriteLine(x);
            }

        }
    }
}