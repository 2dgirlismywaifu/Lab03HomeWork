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

            public Employee(int Id, string firstName, string lastName, int salary)
            {
                this.Id = Id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.salary = salary;
            }

            //vai dong tam su: vc, sao set/get lam the
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
        }

        class Result : Employee
        {
            public Result(int Id, string firstName, string lastName, int salary) : base(Id, firstName, lastName, salary)
            {

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
            Result result = new Result(0124, "Nguyen Van", "Tiep", 20000000);
            result.display();

            Console.ReadKey();
        }
    }
}
