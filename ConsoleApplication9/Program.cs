/*1.	Создать коллекцию List <int> . Вывести на экран позицию и значение элемента, являющегося вторым максимальным значением в коллекции.
 *  Вывести на экран сумму элементов на четных позичиях.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections

{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 32, 34, 5, 6, 64 };
        
            for (int i = 0; i < list.Count; i += 2) {
                Console.WriteLine("i[{0}]={1}", i,list[i]);              
            }
            Console.WriteLine("Сумма элементов на четных позициях = {0}", list.Sum());
            for (int i = 0; i < list.Count; i++)
            {
                int max = list.Max();
                list.Remove(max);
                int newMax = list.Max();
                int sum = list.Sum();                
                Console.WriteLine("Второй максимальный элемент - {0}; index - {1}:", newMax, list.IndexOf(newMax));
                break;
            }

            Console.ReadLine();
        }
    }
}
