using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ownlibary
{
    public class Class1
    {
        [DllImport(@"8Ball.dll", EntryPoint = "?setAnsage@eightball@eightballdll@@SAXH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern void setAnsageOld(int i);
        [DllImport(@"8Ball.dll", EntryPoint = "?firstHit@eightball@eightballdll@@SAHH_NPEAH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern int firstHitOld(int c, bool hit );
        [DllImport(@"8Ball.dll", EntryPoint = "?stoss@eightball@eightballdll@@SAHHPEAH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern int stossOld(int c);

        public static void setAnsage(int i)
        {
            try
            {
                setAnsageOld(i);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
