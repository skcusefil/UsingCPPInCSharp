using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppCS
{

    class NativeMethods
    {
        private const string path = "DLLCpp";

        [DllImport(path, CallingConvention = CallingConvention.Cdecl)]
        public extern static void test();

        [DllImport(path, CallingConvention = CallingConvention.Cdecl)]
        public extern static void Hello();
    }

    class Program
    {
        static void Main(string[] args)
        {
            NativeMethods.Hello();
            Console.WriteLine();

            NativeMethods.test();

            Console.ReadLine();
        }
    }
}
