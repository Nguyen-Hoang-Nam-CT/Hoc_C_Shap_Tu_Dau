using System;

namespace InPut_OutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            //lệnh console.WriteLine() in giá trị ra màn hình và có dấu xuống dòng ở cuối
            //Console.WriteLine("Nguyen Hoang Nam"); //in ra màn hình chữ Nguyễn Hoàng Nam
            //Console.WriteLine(10);//in ra màn hình số 10
            //Console.WriteLine(10.9f);//in ra màn hình số 10.9 (f là ký hiệu của float)
            //Console.WriteLine(true);//in ra man hinh chu true

            //lệnh Console.Write() in gia tri ra man hinh
            //Console.Write("Hi\n");
            //Console.Write(10);
            //Console.Write(Environment.NewLine);//lệnh xuống dòng
            //Console.Write(10.9f);
            //Console.Write(true);
            //Console.Write(Environment.NewLine);

            //int a = 5;
            //Console.Write("a = " + a);

            //Console.Write("\nBe tap dem: {0} {1} {2} {3}", 1, 2, 3, "Be gioi qua");

            //Console.Write("\n");
            //Console.Write(Console.Read());//đọc một ký tự từ bàn phím và trả về kiểu số nguyên 

            //Console.Write("\n");
            //Console.Write(Console.ReadLine());//đọc 1 chuổi kỷ tự cho đến khi gặp ký tự xuống dòng rồi in ra màn hình
            //Console.ReadKey();//Lệnh dừng màn hình

            //Console.ReadKey();//khong truyen tham so vao thi mat dinh la false
            //Console.ReadKey(false);//hien ky an da nhap len mang hinh
            //Console.ReadKey(true);//an ky tu da nhap len mang hinh

            Console.Write("\nNhap ho ten: ");
            Console.Write("\nHo ten cua ban la: " + Console.ReadLine());
            //chạy hàm trong dấu ngoặc trước rồi tới hàm ở ngoài sau
            Console.Write("\nNhap ngay sinh: ");
            Console.Write("\nNgay sinh cua ban la: " + Console.ReadLine());
            Console.Write("\nNhap que quan: ");
            Console.Write("\nQue quan cua ban la: " + Console.ReadLine());
            //node      = ctrl + k + c
            //mở node   = strl + k + u
        }
    }
}
