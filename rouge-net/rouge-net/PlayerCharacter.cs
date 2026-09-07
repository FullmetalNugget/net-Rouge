using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rouge_net
{
    enum Species
    {
        Maegu,
        Woosa,
        Nova,
        Berserker
    }

    enum Role
    {
        Criminal,
        Rouge,
        Cook
    }

    internal class PlayerCharacter
    {
        public string name;
        public Species species;
        public Role role;

    }
}
