using System;

//Bài 9: Đề dài lắm, lười viết comment vào đây 

namespace bai09
{
    internal class bai09
    {
        abstract class Employee
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

            //dung abstract hoac virtual deu duoc
            public virtual void display()
            {
                Console.WriteLine("Day la noi hien thi thong tin nhan vien");
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
                //return base.getSalary(); //dựa theo gốc getSalary từ class Employee
                return this.salary + this.bonus;
            }

            //ghi de void display()
            public override void display()
            {
                //base.display(); //dựa nguyên gốc virtual void display()
                Console.WriteLine("=======Thong tin nhan vien chuc quan ly=======");
                Console.WriteLine("Ho va ten: " + this.Name);
                Console.WriteLine("Luong co ban: " + this.salary + " VND");
                Console.WriteLine("Thưởng thêm: " + this.bonus + " VND");
                Console.WriteLine("Tong: " + getSalary() + " VND");
            }
        }


        static void Main(string[] args)
        {
            Manager manager = new Manager("Nguyen Van B", 20000000, 3000000);
            manager.display();

            Console.ReadKey();
        }
    }
}
