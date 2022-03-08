using System;




namespace bai10
{
    internal class bai10
    {
        class Person
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

            public void Display(string title)
            {
                Console.WriteLine("=========Thong tin " + title + "=========");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Dia chi: " + this.Address);
            }

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

           
            public void DisplayEmployee(string title)
            {
                base.Display(title);
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

            
            public void DisplayCustomer(string title)
            {
                base.Display(title);
                Console.WriteLine("So du TK: " + this.balance + " VND");
            }

        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Doan Van Thanh", "Ha Noi", 21000000);
            Customer customer = new Customer("Hoang Quang Thinh", "Quang Ninh", 35000000);

            employee.DisplayEmployee("nhan vien");
            customer.DisplayCustomer("khach hang");

            Console.ReadKey();
        }
    }
}
