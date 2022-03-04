using System;

//Câu 2: Viết chương trình khai báo một lớp Phương trình bậc 2 với các thuộc tính là a, b, c 
//với các phương thức sau: 
//Hàm tạo không tham số. 
//Hàm tạo có 3 tham số. 
//Get/set cho 3 thuộc tính. Phương thức tính delta. 
//Phương thức tính nghiệm phương trình

namespace bai02
{
    internal class bai02
    {
        class PTBac2
        {
            public float a;
            public float b;
            public float c;

            //ham tao khong tham so
            public PTBac2()
            {
                a = 0;
                b = 0;
                c = 0;
            } 

            //ham tao co 3 tham so
            public PTBac2(float a, float b, float c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            //get/set cac thuoc tinh
            public float A
            {
                get { return a; }
                set { a = value; }
            }

            public float B
            {
                get { return b; }
                set { b = value; }
            }

            public float C
            {
                get { return c; }
                set { c = value; }
            }

            //hien phuong trinh bac 2 
            public void show()
            {
                Console.WriteLine("Phuong trinh bac 2:");
                Console.WriteLine(a + "x^2 + " + b + "x + " + c + " = 0");
            }

            //phuong thuc tinh delta 
            public float delta()
            {
                return b * b - 4 * a * c;
            }

            //phuong thuc tinh nghiem phuong trinh 
            public void result()
            {
                float x1, x2; //hai nghiem cua phuong trinh
               
                if (delta() > 0)
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    x1 = (float)((-b + Math.Sqrt(delta())) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta())) / (2 * a));
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
                else if (delta() == 0)
                {
                    x1 = -(b / a);
                    Console.WriteLine("Phuong trinh co 2 nghiem kep");
                    Console.WriteLine("x1 = x2 = " + x1);
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
        }
        static void Main(string[] args)
        {
            PTBac2 ptbac2 = new PTBac2(3,8,5);
            ptbac2.show();
            ptbac2.result();

            Console.ReadKey();
        }
    }
}
