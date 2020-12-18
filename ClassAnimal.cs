using System;
using System.Text;

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
            first.Name = "mammal";
            Animal second = new Animal();
            second.Name = "reptile";
            Animal third = new Animal();
            third.Name = "insect";
            Animal fourth = new Animal();
            fourth.Name = "unknown";

            
            Console.WriteLine("Animal:");

           string newAnimal= Console.ReadLine();

            if(newAnimal=="dog"||newAnimal=="cat"||newAnimal=="elephant")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, first.Name);
            }    
            
            else if(newAnimal=="crocodile"||newAnimal=="turtle"||newAnimal=="snake")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, second.Name);
            }
            
            else if (newAnimal=="spider"||newAnimal=="cocroach"||newAnimal=="wasp")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, third.Name);
            }    
            
            else 
            {
                Console.WriteLine("{0] is {1}", newAnimal,fourth.Name);
            }

        }

    }
}
