using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {
       

      static public void Check(string FirstNumber, string SecondNumber)
        {
            //1 задание
            if (FirstNumber==""|| SecondNumber=="")
            {
                throw new ArgumentNullException();
            }

            if (int.Parse(SecondNumber)==0)
            {
                throw new ArgumentException();
            }
            else
            {
               Console.WriteLine( double.Parse(FirstNumber) / double.Parse(SecondNumber));
            }
        }
        //2 задание
        static public void Arrays()
        {
            int[] array = new int[3];
            for (int i =0;i<=array.Length+1;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
          static void Main(string[] args)
          {
            //1 задание
            try
            {
                
                string FirstNumber, SecondNumber;
                Console.WriteLine("Введите первое число");
                FirstNumber = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                SecondNumber = Console.ReadLine();
                Check(FirstNumber, SecondNumber);

                
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Не введены числа");


            }
            catch(ArgumentException)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            // 2 задание

            try
            {
                Arrays();
            }
            catch(IndexOutOfRangeException expeption)
            {
                Console.WriteLine(expeption.Message);

            }
            finally
            {
                Console.WriteLine("Завершается обработка массива");
            }

            Console.ReadLine();

           
            


          }
    }

    
}
