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
            int a = 23;
            int b = 21;
            int c = a%b;
            Console.WriteLine("C có giá trị là " + c);

            

        }
        
    }
}
