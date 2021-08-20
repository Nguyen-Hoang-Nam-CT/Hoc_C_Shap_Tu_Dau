using System;

namespace Bien
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5; // giong ben c++ nen khong khong cmt :))
            float b =5.1f;
            string c = "Nam"; 
            bool d = true;
            char e = 'a';
            Console.WriteLine("{0} + {1} = {2} ", a, b, a + b);
            Console.ReadKey();
        }
    }
}
/*
 * Quy tắc đặt tên biến của lập trình viên
 * QUA TẮC LẠC ĐÀ
 *      -Viết thường chữ đầu và viết hoa chữ cái đầu tiên của những chữ tiếp theo vd: int nguyenHoangNam
 *      -Thường dùng cho private, protected
 *      
 * QUY TẮC PASCAL
 *      -Viết hoa chữ đầu tiên của mỗi từ vd: NguyenHoangNam
 *      -Thường dùng cho biến public,phương thức,... nói chung là cho những thằng con lại
 * Lưu ý:
 *      -Nên đặt tên ngắn gọn dễ hiểu, thể hiện rõ mục tiêu của biến
 */