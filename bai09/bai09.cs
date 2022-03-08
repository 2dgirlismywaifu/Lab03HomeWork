using System;


namespace bai09
{
    internal class bai09
    {
        class Employee
        {
            public string Name; //tên nhân viên
            public int salary; //lương nhân viên

            public Employee (string Name, int salary)
            {
                this.Name = Name;
                this.salary = salary;
            }

            public void setName(string Name)
            {
                setName(Name);
            }
            public string getName()
            {
                return Name;
            }
            
            public void setSalary(int salary)
            {
                setSalary(salary);
            }
            public virtual int getSalary()
            {
                return salary;
            }

            
            public void display(string title)
            {
                Console.WriteLine("=======Thong tin nhan vien chuc " + title + "=======");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Luong co ban: " + this.salary + " VND");
                
            }

        }

        //Khai báo class Manager kế thừa từ class Employee
        class Manager : Employee
        {
            public int bonus; //tiền thưởng thêm cho nhân viên
            
            public Manager(string Name, int salary, int bonus) : base(Name, salary)
            {
                this.bonus = bonus;
            }

            public void setBonus(int bonus)
            {
                setBonus(bonus);
            }
            public int getBonus()
            {
                return bonus;
            }

            //ghi đè phương thức getSalary() từ class Employee vì sẽ cộng lương từ Bonus

            public override int getSalary()
            {
                return this.salary + this.bonus;
            }

            //ghi de void display()
            public  void displayManager(string title)
            {
                base.display(title); //dựa nguyên gốc void display()
                
                Console.WriteLine("Thưởng thêm: " + this.bonus + " VND");
                Console.WriteLine("Tong: " + getSalary() + " VND");
            }
        }


        static void Main(string[] args)
        {
            Manager manager = new Manager("Nguyen Van A", 20000000, 3000000);
            Manager manager1 = new Manager("Nguyen Van B", 10000000, 2000000);
            Manager manager2 = new Manager("Nguyen Van C", 40000000, 3000000);
            manager.displayManager("quan ly");
            manager1.displayManager("quan ly");
            manager2.displayManager("quan ly");

            Console.ReadKey();
        }
    }
}
