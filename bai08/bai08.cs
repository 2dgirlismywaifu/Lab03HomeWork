using System;

//Bai 8: Đề dài quá nên không comment ở đây nữa

namespace bai08
{
    internal class bai08
    {
        class Person
        {
            public string Name;
            public int Age;
            public string Address;

            public Person (string Name, int Age, string Address)
            {
                this.Name = Name;
                this.Age = Age;
                this.Address = Address;
            }

            public void setName (string Name)
            {
                setName (Name);
            }
            public string getName()
            {
                return Name;
            }

            public void setAge(int Age)
            {
                setAge (Age);
            }
            public int getAge()
            {
                return Age;
            }

            public void setAddress (string Address)
            {
                setAddress (Address);
            }
            public string getAddress()
            {
                return Address;
            }

            //khoi tao phuong thuc display() dang truu tuong (abstract)
            //co the su dung dang virtual deu duoc neu khong nhat thiet phai ghi de display()
            //update: da duoc khai sang ve override nen se han che dung
            public void display(string title)
            {
                Console.WriteLine("=========Thong tin " + title + "=========");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Tuoi: " + this.Age);
                Console.WriteLine("Dia chi: " + this.Address);
            }

        }

        class Student : Person
        {
            public double gpa; 
            public Student(string Name, int Age, string Address, double gpa) : base(Name, Age, Address)
            {
                this.gpa = gpa;
            }

            public void setGPA (double gpa)
            {
                setGPA (gpa);
            }
            public double getGPA()
            {
                return gpa;
            }

            public void displayStudent(string title)
            {
                base.display(title);
                Console.WriteLine("Diem trung binh: " + this.gpa);
                
            }
        }

        class Teacher : Person
        {
            public int salary; //luong giao vien

            public Teacher(string Name, int Age, string Address, int salary) : base(Name, Age, Address)
            {
                this.salary = salary;
            }

            public void setSalary (int salary)
            {
                setSalary (salary);
            }
            public int getSalary()
            {
                return salary;
            }

            public void displayTeacher(string title)
            {
                base.display(title);
                Console.WriteLine("Luong: " + this.salary + " VND");
            }
        }

        static void Main(string[] args)
        {
            
            Student student = new Student("Le Quynh An", 16, "Ha Noi", 7.9);
            Teacher teacher = new Teacher("Nguyen Ba Phan", 35, "Hai Phong", 15000000);

            student.displayStudent("hoc sinh");
            teacher.displayTeacher("giao vien");

            Console.ReadKey();

        }
    }
}
