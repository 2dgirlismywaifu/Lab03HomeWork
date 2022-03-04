using System;

//Câu 1: Viết một chương trình khai báo một lớp Rectangle có 2 thuộc tính là chiều dài và 
//chiều rộng và có các phương thức sau:
//• Hàm tạo không tham số. 
//• Hàm tạo có 2 tham số. 
//• Get/set cho các thuộc tính. 
//• Phương thức tính diện tích hình chữ nhật. 
//• Phương thức tính chu vi hình chữ nhật

namespace Lab03
{
    internal class bai01
    {
        //khai bao class Rectangle
        class Rectangle
        {
            public float x;  //chieu dai
            public float y; //chieu rong

            public Rectangle() //ham tao khong tham so
            {
                x = 0;
                y = 0;
            } 
            public Rectangle (float x, float y) //ham tao co tham so
            {
                this.x = x;
                this.y = y;
            }
            //get/set cac thuoc tinh

            public float X
            {
                get { return x; }
                set { x = value; }
            }

            public float Y
            {
                get { return y; }
                set { y = value; }
            }

            //tinh dien tich
            public float getArea()
            {
                return X * Y;
            }

            //tinh chu vi
            public float getPerimeter()
            {
                return (X + Y) * 2;
            }

            public void result()
            {
                Console.WriteLine("Chieu dai: " + X);
                Console.WriteLine("Chieu rong: " + Y);
                Console.WriteLine("Dien tich: " + getArea());
                Console.WriteLine("Chu vi: " + getPerimeter());
            }
        }


        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4,5);
            rectangle.result();
            Console.ReadKey();
        }
    }
}
