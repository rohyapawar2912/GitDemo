
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class Program : ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            PublicAccessModifier publicAccessModifier = new PublicAccessModifier();
            publicAccessModifier.AccessModifier();

            PrivateAccessModifier demo = new PrivateAccessModifier();
            demo.Intro();

            ProtectedAccessModifier protectedAccessModifier = new ProtectedAccessModifier();
            Program program = new Program();
            program.IntroOfProtectedModifier();

            InternalAccessModifier internalAccessModifier = new InternalAccessModifier();
            internalAccessModifier.IntroOfInternalmodifier();

            //Month obj = Month.March;
            //Console.WriteLine(obj);

            int obj = (int)Month.March;
            Console.WriteLine(obj);
        }
    }
}