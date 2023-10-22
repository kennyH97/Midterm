using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class TestEnemy
    {
        public void CreateEnemy(int n, int k, Enemy[] e)
        {
            for (int i = 0; i < n; i++)
            {
                e[i] = new Enemy();
                Console.WriteLine("Nhap thong tin cua Enemy: ");
                Console.Write("Id: ");
                e[i].Id = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(e[i].Id))
                {
                    Console.WriteLine("Retry.");
                    Console.Write("Id:");
                    e[i].Id = Console.ReadLine();
                }

                Console.Write("Name: ");
                e[i].Name = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(e[i].Name))
                {
                    Console.WriteLine("Retry.");
                    Console.Write("Name:");
                    e[i].Name = Console.ReadLine();
                }

                Console.Write("Health: ");
                e[i].Health = int.Parse(Console.ReadLine());
                while (e[i].Health <= 0) 
                {
                    Console.WriteLine("Retry.");
                    Console.Write("Health:");
                    e[i].Health = int.Parse(Console.ReadLine());

                }

                Console.Write("MinDamage: ");
                e[i].MinDamage = int.Parse(Console.ReadLine());
                while (e[i].MinDamage < 0 && e[i].MinDamage > 100)
                {
                    Console.WriteLine("Retry.");
                    Console.Write("MinDamage:");
                    e[i].Health = int.Parse(Console.ReadLine());
                }

                Console.Write("MaxDamage: ");
                e[i].MaxDamage = int.Parse(Console.ReadLine());
                while (e[i].MaxDamage < 0 && e[i].MaxDamage > 100)
                {
                    Console.WriteLine("Retry.");
                    Console.Write("MaxDamage:");
                    e[i].Health = int.Parse(Console.ReadLine());
                }

                
                
            }
        }

        public void SortEnemy(int n, int k, Enemy[] e)
        {

            for (int i = 0; i < k; i++)
            {
                e[i].AvgDamage += (float)e[i].CalculateDamage() / k;
            }
                    
            for (int i = 0; i < k - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (e[j].AvgDamage > e[j + 1].AvgDamage)
                    {
                        Enemy temp = e[j];
                        e[j] = e[j + 1];
                        e[j + 1] = temp;
                    }
                }
            }
             Console.WriteLine("Sap xep danh sach theo sat thuong trung binh: ");
            for (int i = 0; i < n; i ++)
            {
                Console.WriteLine("Name: " + e[i].Name + ", AvgDamage: " + e[i].AvgDamage);
            }

        }

        public void SearchEnemy(int n, int k, Enemy[] e)
        {
            Console.WriteLine("Nhap ten enemy: ");
            string name = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                e[i].AvgDamage += (float)e[i].CalculateDamage() / k;
            }
            for (int i = 0; i < n; i++)
            {
                
                if (string.Compare(e[i].Name, name) == 0)
                {
                    Console.WriteLine("Thong tin cua enemy thu " + (i+1));
                    Console.WriteLine("Id: " + e[i].Id);
                    Console.WriteLine("Name: " + e[i].Name);
                    Console.WriteLine("Health: " + e[i].Health);
                    Console.WriteLine("MinDamae: " + e[i].MinDamage);
                    Console.WriteLine("MaxDamage: " + e[i].MaxDamage);
                    Console.WriteLine("AvgDamae: " + e[i].AvgDamage);
                    count++;
                    break;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("Not found.");
            }
        }

        public void Display(int n, int k, Enemy[] e)
        {
            for (int i = 0; i < k; i++)
            {
                e[i].AvgDamage += (float)e[i].CalculateDamage() / k;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin enemy thu " + (i + 1));
                Console.WriteLine("Id: " + e[i].Id);
                Console.WriteLine("Name: " + e[i].Name);
                Console.WriteLine("Health: " + e[i].Health);
                Console.WriteLine("MinDamae: " + e[i].MinDamage);
                Console.WriteLine("MaxDamage: " + e[i].MaxDamage);
                Console.WriteLine("AvgDamage: " + e[i].AvgDamage);
            }
        }

        public void DeleteEnemy(int n, Enemy[] e)
        {
            Console.WriteLine("Nhap Id cua enemy muon xua: ");
            string id = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (String.Compare(e[i].Name, id) == 0)
                {
                    e[i] = e[n-1];
                    n--;
                }
            }
        }
        
    }
}
