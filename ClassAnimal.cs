using System;

namespace zad
{
    class Animal
    {
        public string Name;

        static void Main(string[]args)
        {

            /* Напишете програма,която отпечатва класа на животното според неговото име,въведено от потребителя.
             курче,котка,слон -> бозайник
             крокодил,костенурка,змия -> влечуго
             паяк,хлебарка,оса-> насекомо
             друго->непознат  */


            Animal first = new Animal();
            first.Name = "бозайник";
            Animal second = new Animal();
            second.Name = "влечуго";
            Animal third = new Animal();
            third.Name = "насекомо";
            Animal fourth = new Animal();
            fourth.Name = "непознат";

            Console.WriteLine("Въведете животно:");

           string newAnimal= Console.ReadLine();

            if(newAnimal=="куче")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, first.Name);
            }    
            if(newAnimal=="котка")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, first.Name);
            }
            if(newAnimal=="слон")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, first.Name);
            }    
            if(newAnimal=="крокодил")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, second.Name);
            }
            if(newAnimal=="констенурка")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, second.Name);
            }    
            if(newAnimal=="змия")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, second.Name);
            }
            if (newAnimal=="паяк")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, third.Name);
            }    
            if (newAnimal=="хлебарка")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, third.Name);
            }
            if (newAnimal == "оса")
            {
                Console.WriteLine("{0} e oт клас {1}", newAnimal, third.Name);
            }
            else 
            {
                Console.WriteLine("{0] е {1}", newAnimal, fourth.Name);
            }

        }

    }
}
