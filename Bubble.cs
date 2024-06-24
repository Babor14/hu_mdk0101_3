using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdk_0101__lab3_
{
   public class Bubble : Container_ab
    {
        private List<int> data = new List<int>();

        public Bubble ( List<int> data )
        {
            this.data = data;
        }

        public override void Sort ()
        {

            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }

        public override void Foreach ()
        {
            foreach (int num in data)
            {
                double sqrt = Math.Sqrt(num);
                Console.WriteLine($"Квадратный корень числа {num}: {sqrt}");
            }
        }
    }
}
