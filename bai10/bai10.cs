using System;


//Bài 10: Đề cũng dài quá, không comment đề nữa

namespace bai10
{
    internal class bai10
    {
        abstract class Person
        {
            public string Name; //Họ và tên
            public string Address; //Địa chỉ

            public Person (string Name, string Address)
            {
                this.Name = Name;
                this.Address = Address;
            }

            public void setName(string Name)
            {
                setName(Name);
            }
            public string getName()
            {
                return Name;
            }

            public void setAddress (string Address)
            {
                setAddress(Address);
            }
            public string getAddress()
            {
                return Address;
            }

            public abstract void Display();

        }

        class Employee : Person //Nhân viên kế thừa Class Person
        {
            public int salary; //Lương của nhân viên
            public Employee(string Name, string Address, int salary) : base(Name, Address)
            {
                this.salary = salary;
            }

            public void setSalary (int salary)
            {
                setSalary(salary);
            }
            public int getSalary() 
            { 
                return salary; 
            }

            //ghi đè void Display() từ class Person
            public override void Display()
            {
                Console.WriteLine("=========Thong tin nhan vien=========");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Dia chi: " + this.Address);
                Console.WriteLine("Luong: " + this.salary + " VND");
            }

        }

        class Customer : Person //Khách hàng kế thừa Class Person
        {
            public int balance; //Số dư tài khoản của khách hàng

            public Customer(string Name, string Address, int balance) : base(Name, Address)
            {
                this.balance = balance;
            }

            public void setBalance (int balance)
            {
                setBalance(balance);
            }
            public int getBalance()
            {
                return balance;
            }

            //ghi đè void Display() từ class Person
            public override void Display()
            {
                Console.WriteLine("=========Thong tin khach hang=========");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Dia chi: " + this.Address);
                Console.WriteLine("So du TK: " + this.balance + " VND");
            }

        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Doan Van Thanh", "Ha Noi", 21000000);
            Customer customer = new Customer("Hoang Quang Thinh", "Quang Ninh", 35000000);

            employee.Display();
            customer.Display();

            Console.ReadKey();
        }
    }
}
