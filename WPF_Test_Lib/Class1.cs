using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool c = (a>=b);

            bool d1 = true;
            bool d2 = true;
            bool d3 = !d1;
            Console.WriteLine("C có giá trị là " + d3);
       
        }

        [Test]

        public void CauLenhIF()
        {
            int Diem = 100;
            if (Diem >=85)
            {
                Console.WriteLine("Xếp loại giỏi");

            }
            else if (Diem >=70)
            {
                Console.WriteLine("Xếp loại Khá");
            }
            else if (Diem >=50)

            {
                Console.WriteLine("Xếp loại TB");
            }    
            
            else
            {
               Console.WriteLine("Xếp loại Yếu");
            }


        }
    }
}
