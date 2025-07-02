using NUnit.Framework;
using System;

namespace WPF_Test_Lib
{


    [TestFixture]
    public class Class1
    {
        int age;
        string name;
        string email;

        enum Mua { Xuan = 1, Ha = 2, Thu = 3, Dong = 4 };


        [Test]

        public void TinhCong()
        {
            int a = 21;
            int b = 21;
            bool c = (a >= b);

            bool d1 = true;
            bool d2 = true;
            bool d3 = !d1;
            Console.WriteLine("C có giá trị là " + d3);

        }

        [Test]

        public void CauLenhIF()
        {
            int Diem = 100;
            if (Diem >= 85)
            {
                Console.WriteLine("Xếp loại giỏi");

            }
            else if (Diem >= 70)
            {
                Console.WriteLine("Xếp loại Khá");
            }
            else if (Diem >= 50)

            {
                Console.WriteLine("Xếp loại TB");
            }

            else
            {
                Console.WriteLine("Xếp loại Yếu");
            }
        }

        [Test]

        public void CauLenhSwitch()
        {
            int LoaiXe = 56;

            switch (LoaiXe)
            {
                case 1:
                    {
                        Console.WriteLine("Xe đạp");
                    }

                    break;

                case 2:
                    {
                        Console.WriteLine("Xe máy");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Ô tô");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Done");
                    }
                    break;
            }

        }




        [Test]

        public void VonglapFor()
        {
            int SoLanLap = 5;
            for (int i = 1; i <= SoLanLap; i++)
            {
                Console.WriteLine("Gửi Email lần thứ " + i);
            }

        }
        [Test]

        public void VonglapForEach()
        {
            string[] DanhSachTen = { "Toàn", "Tuấn", "Hùng", "Quân", "Tùng" };

            foreach (string Ten in DanhSachTen)
           
            {
                Console.WriteLine("Tên nhân viên: " + Ten);
            } 
          
        }
        [Test]

        public void VonglapWhile()
        {
           int Count = 0;
            while (Count < 5)
            {
                Console.WriteLine("Đây là vòng lặp While lần thứ: " + Count);
                Count++;
            }
        }
        [Test]

        public void VonglapDoWhile()
        {
            int Count = 5;
            do

            {
                Console.WriteLine("Đây là vòng lặp While lần thứ: " + Count);
                Count++;
            }
            while (Count < 5);
        }
        [Test]

        public void CuPhapBreak()
        {
            int SoLanLap = 5;
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("Gửi Email lần thứ:" + i);
                if (i == 10)
                {
                    break;
                }    
            }    
        }

        [Test]
        public void DoiTuong()
        {
            Nguoi MrToan = new Nguoi();
            MrToan.Name = "Toàn";
            MrToan.Age = 30;
            MrToan.Email = "Toannh06@gmail.com";
            MrToan.Noichuyen();

            Nguoi MrBon = new Nguoi();
            MrBon.Name = "Bon";
            MrBon.Age = 10;
            MrBon.Email = "Bon@gmail.com";
            MrBon.Noichuyen();

            MrToan.Noichuyen();

            int a = 25;
            Console.WriteLine("Giá trị của a: " +a);
            int b=a;
            b = 15;
            Console.WriteLine("Giá trị của b: " +b);
            Console.WriteLine("Giá trị của a: " +a);

            MrToan = null;
            MrBon  = null;

        }
        public class Nguoi
        {
            public string Name;
            public int Age;
            public string Email;
            public void Noichuyen()
            {
                Console.WriteLine("Xin chào, tôi là " + Name);
            }
            
        }
    }
}
