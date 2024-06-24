using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mdk_0101__lab3_;
namespace mdk_0101__lab3_
{
    internal class Program
    {
        static void Main ( string[] args )
        {
            List<int> testData = new List<int> { 9, 16, 4, 1, 25 };

            Bubble bubbleContainer = new Bubble(testData);
            Console.WriteLine("Сортировка методом пузырька:");
            bubbleContainer.Sort();
            bubbleContainer.Foreach();

            Console.WriteLine();

            Choice choiceContainer = new Choice(testData);
            Console.WriteLine("Сортировка методом выбора:");
            choiceContainer.Sort();
            choiceContainer.Foreach();
        }
    }
}
