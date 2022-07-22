using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class SizeOfExample
    {
        public void Run()
        {
            //Console.WriteLine(sizeof(byte));
            DisplaceSizeOf<byte>();
            DisplaceSizeOf<short>();
            DisplaceSizeOf<ushort>();
            DisplaceSizeOf<int>();
            DisplaceSizeOf<Point1>();
            DisplaceSizeOf<Point2>();
        }

        public static unsafe void DisplaceSizeOf<T>() where T : unmanaged
        {
            Console.WriteLine($"The size of a {typeof(T)} is: {sizeof(T)}");
        }

        public struct Point1
        {
            public decimal X;
            public decimal Y;
             public decimal Z;
        }
    }
    public struct Point2
    {
        public decimal X;
        public decimal Y;
        public decimal Z;
    }
}
