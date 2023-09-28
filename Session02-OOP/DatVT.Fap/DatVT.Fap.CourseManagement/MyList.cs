using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatVT.Fap.CourseManagement
{
    /// <summary>
    /// Class này được thiết kế theo kĩ thuật Generic
    /// tức là nó sẽ chơi vs đủ mọi loại class khác nhau
    /// mún chơi class nào thì chơi class đó vào
    /// kiểu dữ liệu/data type/ class cũng là loại data type
    /// sẽ trở thành tham số đầu vào cho đâu đó
    /// TYPE PARAMETER
    /// </summary>
    internal class MyList<T>  
    {   //chữ T là Generic
        //mỗi lần mún xài class này, đưa loại data type vào , <Student> <Course>
        T[] _list = new T[10]; //hard code chút 1 mảng lưu 10 gì đó
        int _count = 0; //biến đếm só object đã đc đưa vào mảng 
        //hàm add mới 1 bạn object nào đó vào trong mảng
        public void AddNew(T obj)
        {
            _list[_count++] = obj;  //_list[count++] = obj; count++;
                                    //viết cẩn thận
            
        }
        public void PrintAll()
        {   
            if(_list.Length == 0) {
                Console.WriteLine("There is nothing to print");
            }
            //for (int i = 0; i < _list.Length; i++)
            //{
            //    Console.WriteLine("The component" +_list[i].ToString());
            //}
            foreach (T x in _list) 
            {
                Console.WriteLine(x.ToString());    //gọi hàm ToString()
                //với mọi x thuộc mảng
                //x là 1 object thuộc T, T có thể là Student, Lecturer
                //0976849500: Anh Huy ngành embeded
            }
        }
    }
}
