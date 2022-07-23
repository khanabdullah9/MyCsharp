using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class TowerOfHanoi
    {
        /*For 3 plates*/
        public void Solve(int disk, char source, char middle, char dest) 
        {
            if (disk == 0) 
            {
                Console.WriteLine($"Plate {disk} from {source} to {dest}");
                return;
            }
            //we move n-1 rod to the middle rod
            Solve(disk-1,source,dest,middle);//hence on the recursive call the destination becomes middle
            Console.WriteLine($"Plate {disk} from {source} to {dest}");
            Solve(disk - 1, middle, source, dest);
        }
    }
}
