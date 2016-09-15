using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Class1
    {

        string chaine;

        Class1()
        {
            chaine = "initialisation";
            var titi = new StringBuilder();

            titi.Append(chaine);

            Console.WriteLine(titi.ToString());
        }
    }
}
