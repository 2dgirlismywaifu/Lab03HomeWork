using System;

//Câu 7: hãy tạo hai lớp Employee với các thông tin như sau:
//id: int
//firstName: string 
//lastName: string
//salary: int
//Employee(id: int, firstName: String, lastName: String, salary: int)
//setId(id: int): void
//getId(): int
//setFirstName(firstName: string): void
//getFirstName(): string
//setLastName(lastName: string): void
//getLastName(): string
//setSalary(salary: int): void
//getSalary(): int
//getFullName(): string
//Giải thích: 
//id, firstName, lastName, salary là các thuộc tính chỉ mã, tên, họ, tiền lương của đối tượng 
//nhân viên.
//Employee(id: int, firstName: String, lastName: String, salary: int) là phương thức khởi tạo 
//có tham số dùng để khởi tạo giá trị cho các thuộc tính.
//getFullName() là phương thức trả về firstName + lastName.

namespace bai07
{
    internal class bai07
    {
        class Employee
        {
            public int Id;
            public string firstName;
            public string lastName;
            public int salary;

            //public Employee(int Id, string firstName, string lastName, int salary)
            //{
            //    this.Id = Id;
            //    this.firstName = firstName;
            //    this.lastName = lastName;
            //    this.salary = salary;
            //}

            public Employee() { }
            
            public void setId (int Id)
            {
                setId (Id);
            }
            public int getId()
            {
                return Id;
            }

            public void setFirstName (string firstName)
            {
                setFirstName (firstName);
            }
            public string getFirstName()
            {
                return firstName;
            }

            public void setLastName(string lastName)
            {
                setLastName(lastName);
            }
            public string getLastName()
            {
                return lastName;
            }

            public void setSalary(int salary)
            {
                setSalary (salary);
            }
            public int getSalary()
            {
                return salary;
            }

            public string getFullName()
            {
                return getFirstName() + " " +getLastName();
            }

            public void inputInfo()
            {
                Console.WriteLine("======Nhap thong tin nhan vien======");
                Console.Write("Ma nhan vien: ");
                Id = int.Parse(Console.ReadLine());
                Console.Write("Ho: ");
                firstName = Console.ReadLine();
                Console.Write("Ten: ");
                lastName = Console.ReadLine();
                Console.WriteLine("Luong: ");
                salary = int.Parse(Console.ReadLine());
            }

            public void display()
            {
                Console.WriteLine("======Thong tin nhan vien======");
                Console.WriteLine("Ma nhan vien: " + getId());
                Console.WriteLine("Ho va ten: " + getFullName());
                Console.WriteLine("Luong: " + getSalary() + " VND");
            }
        }

       

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.inputInfo();
            employee.display();

            Console.ReadKey();
        }
    }
}
