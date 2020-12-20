using System;
using System.Text;

namespace zad
{
    class Animal
    {
        public string Type;

        static void Main(string[]args)
        {

            /* Напишете програма,която отпечатва класа на животното според неговото име,въведено от потребителя.
             курче,котка,слон -> бозайник
             крокодил,костенурка,змия -> влечуго
             паяк,хлебарка,оса-> насекомо
             друго->непознат  */


            Animal first = new Animal();
            first.Type = "mammal";
            Animal second = new Animal();
            second.Type = "reptile";
            Animal third = new Animal();
            third.Type = "insect";
            Animal fourth = new Animal();
            fourth.Type = "unknown";

            
            Console.WriteLine("Animal:");

           string newAnimal= Console.ReadLine();

            if(newAnimal=="dog"||newAnimal=="cat"||newAnimal=="elephant")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, first.Type);
            }    
            
            else if(newAnimal=="crocodile"||newAnimal=="turtle"||newAnimal=="snake")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, second.Type);
            }
            
            else if (newAnimal=="spider"||newAnimal=="cocroach"||newAnimal=="wasp")
            {
                Console.WriteLine("{0} is from class {1}", newAnimal, third.Type);
            }    
            
            else 
            {
                Console.WriteLine("{0] is {1}", newAnimal,fourth.Type);
            }

        }

    }
}
