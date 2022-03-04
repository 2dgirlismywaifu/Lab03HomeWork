using System;

//Câu 3: Viết chương trình khai báo một lớp trừu tượng là Animal có phương thức eat() và
//makeSound(). 
//Xây dựng các lớp Cat và Bird kế thừa lớp Animal trong đó: Lớp Cat có phương thức run() 
//Lớp Bird có phương thức fly()

namespace bai03
{
    internal class bai03
    {
        //khai bao abstract class Animal
        abstract class Animal
        {
            public virtual void eat()
            {
                Console.WriteLine("Dong vat dang an");
            }

            public virtual void makesound()
            {
                Console.WriteLine("Dong vat dang keu");
            }
            
        }

        class Cat : Animal
        {
            public override void eat() //ghi de phuong thuc eat()
            {
                Console.WriteLine("Meo dang an ca");
            }

            public override void makesound() //ghi de phuong thuc makesound()
            {
                Console.WriteLine("Meo meo meo meo meo");
            }

            public void run() 
            {
                Console.WriteLine("Meo dang chay bang 4 chan");
            }
        }

        class Bird : Animal
        {
            public override void eat() //ghi de phuong thuc eat()
            {
                Console.WriteLine("Chim dang bat sau");
            }

            public override void makesound() //ghi de phuong thuc makesound()
            {
                Console.WriteLine("Chim dang hot veo vo");
            }

            public void fly()
            {
                Console.WriteLine("Chim dang bay tren bau troi");
            }
        }

        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Bird bird = new Bird();

            //goi phuong thuc

            cat.eat();
            cat.makesound();
            cat.run();

            Console.WriteLine("==================================");

            bird.eat();
            bird.makesound();
            bird.fly();

            Console.ReadKey();
        }
    }
}
