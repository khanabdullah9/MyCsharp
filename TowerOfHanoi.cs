using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class TowerOfHanoi
    {
        public void Solve(int disk, char source, char middle, char dest) 
        {
            if (disk == 0) 
            {
                Console.WriteLine($"Plate {disk} from {source} to {dest}");
                return;//stack frame is removed
            }
            //we move n-1 rod to the middle rod
            Solve(disk-1,source,dest,middle);//Moving from the source to the middle//hence on the recursive call the destination becomes middle
            Console.WriteLine($"Plate {disk} from {source} to {dest}");//NOTE: after hitting the base case the implementation will come to the line
            Solve(disk - 1, middle, source, dest);//Moving from the middle to destination//stack frame is removed
        }
    }
}
/*
 * NOTE FOR STACK VISUALISATION: When you trigger the base condition first make the changes then return the stack frame
 */
