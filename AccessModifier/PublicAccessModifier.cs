using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    //Access modifiers are the keyboards witch specifies the accebility or scope of a variable or a function
    //it will control the visibility of a class
    public class PublicAccessModifier
    {
        // public modifier allow a part of a program in the same assembly or a doffferent assembly to access the type and
        public void AccessModifier()
        {
            Console.WriteLine("It is Public Access modifier.");
            PrivateAccessModifier demo = new PrivateAccessModifier();
            demo.Intro();
        }



    }
}


