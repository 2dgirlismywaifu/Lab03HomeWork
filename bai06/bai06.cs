using System;

//Hãy khai báo lớp Circle với thông tin như sau:
//radius: double
//Circle(radius: double)
//getArea(): double
//getCircumference(): double
//Giải thích:
//radius là thuộc tính chỉ bán kính của đường tròn
//Circle(radius: int) là phương thức khởi tạo có tham số dùng để gán giá trị cho thuộc tính 
//radius
//getArea() và getCircumference() là hai phương thức trả về diện tích và chu vi của hình 
//tròn với pi (π) = 3.14

namespace bai06
{
    internal class bai06
    {
        public const double PI = 3.14;

        class Circle
        {
            public double radius { get; set; } //ban kinh hinh tron
            
            public Circle (double radius)
            {
                this.radius = radius;
            }

            public double getArea() //dien tich
            {
                return radius * radius * PI;
            }

            public double getCircumference() //chu vi
            {
                return radius * 2 * PI;
            }

        }

        class Result : Circle
        {
            

            public Result(double radius) : base(radius)
            {
                
            }

            public void display()
            {
                Console.WriteLine("=======Thong tin hinh tron=======");
                Console.WriteLine("Ban kinh: " + this.radius);
                Console.WriteLine("Chu vi: " + getCircumference());
                Console.WriteLine("Dien tich: " + getArea());
            }

        }

        static void Main(string[] args)
        {
            //co the khong can goi class circle
            //vi class result ke thua lai class circle nen se ghi de radius
            //Circle circle = new Circle(4); 
            Result result = new Result(3);
            result.display();

            Console.ReadKey();
        }
    }
}
