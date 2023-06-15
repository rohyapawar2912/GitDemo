using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    public class PrivateAccessModifier
    {
        //it resticate other program part from accessinging its types and its members.
        private void IntroOfPrivateModifier()
        {
            Console.WriteLine("This is Private Modifier.");
        }

        public void Intro()
        {
            IntroOfPrivateModifier();
        }
    }
}
