using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong Enemy");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nhap so lan ra don cua cac enemy: ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            Enemy[] enemy = new Enemy[n];
            TestEnemy testEnemy = new TestEnemy();
            while (true)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Nhap thong tin Enemy");
                Console.WriteLine("2. Sap xep danh sach Enemy theo sat thuong TB");
                Console.WriteLine("3. Hien thi tat ca Enemy");
                Console.WriteLine("4. Tim kiem Enemy theo ten");
                Console.WriteLine("5. Xoa Enemy theo id");
                Console.WriteLine("6. Thoat chuong trinh");
                Console.WriteLine("=============================================");
                Console.WriteLine("Chon chuc nang: ");
                int option = Convert.ToInt32(Console.ReadLine());
             
                switch (option)
                {
                    case 1:
                        Console.WriteLine();
                        testEnemy.CreateEnemy(n, k, enemy);
                        break;
                    case 2:
                        
                        testEnemy.SortEnemy(n, k, enemy);                       

                        break;
                    case 3:
                        Console.WriteLine();
                        testEnemy.Display(n, k, enemy);
                        break;
                    case 4:
                        Console.WriteLine();
                        testEnemy.SearchEnemy(n, k, enemy);
                        break;
                    case 5:
                        Console.WriteLine();
                        testEnemy.DeleteEnemy(n, enemy);
                        break;
                    case 6:
                        return ;
                        break;
                }
                Console.WriteLine("Press anything to clear.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}