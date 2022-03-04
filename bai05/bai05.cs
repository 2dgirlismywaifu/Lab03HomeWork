using System;

//Tạo ra một đối tượng thuộc lớp Rectangle (hình chữ nhật) giống như sau:
//length: double
//width: double
//getInformation(): void
//display(): void
//getArea(): double
//getPerimeter: double
//Trong đó:
//length và width là hai thuộc tính chỉ chiều dài và chiều rộng của hình chữ nhật. 
//getInformation() là phương thức nhập dữ liệu cho thuộc tính length và width từ bàn phím. 
//display() là phương thức dùng để hiển thị thông tin về chu vi và diện tích của hình chữ
//nhật ra màn hình.
//getArea() và getPerimeter() là hai phương thức trả về diện tích và chu vi của hình chữ
//nhật, hai phương thức này được dùng trong phương thức display()

namespace bai05
{
    internal class bai05
    {
        class Rectangle
        {
            public double length { get; set; }  //chieu dai
            public double width { get; set; } //chieu rong

            public Rectangle ()
            {
                length = 0;
                width = 0;
            }

            public Rectangle (double length, double width)
            {
                this.length = length;   
                this.width = width;
            }

            public void getInformation()
            {
                Console.WriteLine("========Nhap thong tin tu ban phim========");
                Console.Write("Nhap chieu dai: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            public double getArea() //dien tich
            {
                return length * width;
            }

            public double getPerimater() //chu vi
            {
                return (width + length) * 2;
            }

            public void display() //hien thi thong tin
            {
                Console.WriteLine("========Thong tin hinh chu nhat========");
                Console.WriteLine("Chieu dai: " + this.length);
                Console.WriteLine("Chieu rong: " + this.width);
                Console.WriteLine("Chu vi: " + getPerimater());
                Console.WriteLine("Dien tich: " + getArea());
            }
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.getInformation();
            rect.display();

            Console.ReadKey();
        }
    }
}
