using System;

//Bạn hãy viết chương trình khai báo lớp Student với thông tin giống như sau
//+ name: string
//+ age: int
//+ getInformation: void
//+ display: void
//name và age là hai thuộc tính dùng để lưu trữ tên và tuổi của đối tượng học sinh. 
//display() là phương thức dùng để hiển thị thông tin của đối tượng ra màn hình.
//getInformation() là phương thức dùng để nhập dữ liệu cho thuộc tính name và age từ bàn 
//phím


namespace bai04
{
    internal class bai04
    {
        class Student
        {
            public string Name { get; set; } //ten hoc sinh
            public int age { get; set; } //tuoi hoc sinh
            
            public Student(string Name, int age)
            {
                this.Name = Name;
                this.age = age;
            }

            public Student()
            {
                
            }

            public void getInformation()
            {
                Console.WriteLine("========Nhap thong tin========");
                Console.Write("Ten hoc sinh: ");
                Name = Console.ReadLine();
                
                Console.Write("Tuoi: ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("");
            }

            public void display()
            {
                Console.WriteLine("");
                Console.WriteLine("========Thong tin vua nhap tu ban phim========");
                Console.WriteLine("Hoc sinh: " + this.Name);
                Console.WriteLine("Tuoi: " + this.age);
            }

        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.getInformation();
            student.display();

            Console.ReadKey();
        }
    }
}
