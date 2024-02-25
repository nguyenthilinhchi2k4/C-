using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PhoneBook phoneBook = new PhoneBook();

            phoneBook.InsertPhone("Hung", "0123456789");
            phoneBook.InsertPhone("Ly", "0987654321");
            phoneBook.InsertPhone("Binh", "0906552368");
            phoneBook.InsertPhone("Linh", "0956998236");
            phoneBook.InsertPhone("Minh", "09563225698");
            phoneBook.InsertPhone("Dung", "03652236814");
            phoneBook.InsertPhone("Cong", "0956225456");
            phoneBook.InsertPhone("Thai", "0996223456");
            phoneBook.InsertPhone("Dat", "0365224968");
            phoneBook.InsertPhone("Long", "0985996542");
            phoneBook.InsertPhone("Viet", "0963221456");
            phoneBook.InsertPhone("Vy", "0354220125");

            phoneBook.DisplayPhoneBook(); // Hien thi danh ba dien thoai truoc khi tim kiem

            Console.WriteLine("\nTim kiem:");

            // Đọc chuỗi từ người dùng để tìm kiếm
            string searchKeyword = Console.ReadLine();

            phoneBook.SearchPhone(searchKeyword); // Hien thi ket qua tim kiem

            Console.WriteLine("\nThem moi:");

            // Đọc thông tin từ người dùng để thêm vào danh bạ
            Console.Write("Nhap ten: ");
            string newName = Console.ReadLine();
            Console.Write("Nhap so dien thoai: ");
            string newPhone = Console.ReadLine();

            phoneBook.InsertPhone(newName, newPhone); // Them moi vao danh ba

            phoneBook.DisplayPhoneBook(); // Hien thi danh ba sau khi them moi

            Console.WriteLine("\nXoa:");

            // Đọc thông tin từ người dùng để xóa khỏi danh bạ
            Console.Write("Nhap ten can xoa: ");
            string removeName = Console.ReadLine();

            phoneBook.RemovePhone(removeName); // Xoa trong danh ba

            phoneBook.DisplayPhoneBook(); // Hien thi danh ba sau khi xoa

            Console.WriteLine("\nNhan Enter de ket thuc.");
            Console.ReadLine(); //Enter để kết thúc chương trình
        }
    }
}
        
        