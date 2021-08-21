//https://www.howkteam.vn/course/khoa-hoc-lap-trinh-c-can-ban/kieu-du-lieu-trong-c-53 link học
using System;

namespace KieuDuLieuCuaCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            //phần 1
            ////kiểu số nguyên
            byte a = 10;
            //short b = 10;
            //int c = 10;
            //long d = 10;
            ////kiểu số thực
            //float e = 10.1f; //giá trị của biến kiểu float phải có hậu tố f hoặc là F
            //double f = 10.1; //giá trị của double không cần hậu tố
            //decimal g = 10.1m;//giá trị của biến decimal phải có hậu tố m hoặc M
            ////kiểu chuổi và kiểu ký tự
            //char h = 'h';
            //string i = "hihi ghi duoc mot chuoi luon";


            //Phần 2
            byte bienbyte = 3;
            short bienshort = 9;
            int bienint = 10;
            long bienlong = 0;

            bienlong = bienbyte; // bienlong có kiểu dữ liệu lớn hơn bienbyte nên giá trị bienbyte có thể gán qua cho bienlong
            Console.WriteLine(" bienlong = " + bienlong);

            bienlong = bienint;
            Console.WriteLine(" bienlong = {0}", bienlong);

            bienshort = bienbyte; // tương tự như trên
            Console.WriteLine(" bienshort = " + bienshort);

            bienint = bienshort;
            Console.WriteLine(" bienint = " + bienint);
    



            //phần 3
            //int a;
            //Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.

            //int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.

            //byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá ngoài vùng này được.

            //string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bẳng cặp dấu "" thay vì ''. 

            //long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte, . . .
            //long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?

            //int g = 10;
            //byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn mặc dù trong trường hợp này ta thấy số 10 đều có thể gán cho 2 biến.

            //string k = "Kteam";
            //Console.WriteLine(" k = " + K); // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K (C# có phân biệt chữ hoa, thường cần lưu ý để tránh gặp lỗi)


            Console.ReadKey();
        }
    }
}
/*
    Kiểu dữ liệu
        - Là tập hợp các nhóm dữ liệu có cùng đặt tính  
        - Là tính hiệu để trình biên dịch nhận biết kích thước của một biến và khả năng của nó
    Có 2 kiểu dữ liệu
      => Dựng sẵn
      => Người lập trình tự định nghĩa
    Kiểu dữ liệu giá trị
        ...trong file work
    Kiểu dữ liệu 
        ...trong file work
 */
