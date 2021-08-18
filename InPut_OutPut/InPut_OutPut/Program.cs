using System;

namespace InPut_OutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            //lệnh console.WriteLine() in giá trị ra màn hình và có dấu xuống dòng ở cuối
            Console.WriteLine("Nguyen Hoang Nam"); //in ra màn hình chữ Nguyễn Hoàng Nam
            Console.WriteLine(10);//in ra màn hình số 10
            Console.WriteLine(10.9f);//in ra màn hình số 10.9 (f là ký hiệu của float)
            Console.WriteLine(true);//in ra man hinh chu true

            //lệnh Console.Write() in gia tri ra man hinh
            Console.Write("Hi\n");
            Console.Write(10);
            Console.Write(Environment.NewLine);//lệnh xuống dòng
            Console.Write(10.9f);
            Console.Write(true);

            Console.ReadKey();//Lệnh dừng màn hình
            //node      = ctrl + k + c
            //mở node   = strl + k + u
        }
    }
}
