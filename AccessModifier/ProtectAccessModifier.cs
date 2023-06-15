using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class ProtectedAccessModifier
    {
        // Allow code whithin the same class and inherited class and its member.
        protected void IntroOfProtectedModifier()
        {
            Console.WriteLine("This is Protected Modifier.");
        }
    }
}