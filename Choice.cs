using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101__lab3_
{
   public  class Choice : Container_ab
    {
        private List<int> data = new List<int>();

        public Choice ( List<int> data )
        {
            this.data = data;
        }

        public override void Sort()
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (data[j] < data[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = data[i];
                data[i] = data[minIndex];
                data[minIndex] = temp;
            }
        }

        public override void Foreach()
        {

            foreach (int num in data)
            {
                int result = num * 2 + 5;
                Console.WriteLine($"Результат алгоритма для числа {num}: {result}");
            }
        }
    }
}
