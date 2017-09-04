using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Person Jhon = new Person(1.86f,105f);//altura e peso
           
      
            Console.WriteLine("Idade de Jhon " + Jhon.age);
            Jhon.age = 21;
            Console.WriteLine("Nova idade de Jhon " + Jhon.age);

            //p.imc = 21.45 

            Console.WriteLine("Height " + Jhon.getHeight() + " and ewight " + Jhon.getWeight());


            Person Peter = new Person(height: 1.86f, weight: 105f, age: 19);
            Console.WriteLine("Idade de peter " + Peter.age);

            Console.WriteLine("Jhon IMC is " + Jhon.getImc());

            Jhon.setWeight(80);

            Console.WriteLine("ImC de jhon eh: " +Jhon.getImc());

        }
    }
}
