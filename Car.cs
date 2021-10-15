using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Car
    {
        int maxSpeed = 200;
        double weight = 3000;
        string color = "red";
        char grade = 'A';

        public void printAll() 
        {
            Console.WriteLine(maxSpeed);
            Console.WriteLine(weight);
            Console.WriteLine(color);
            Console.WriteLine(grade);
        }

        public void wreckCar() 
        {
            grade = 'B';
        }
    }
}
