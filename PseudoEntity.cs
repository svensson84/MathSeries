using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSeries
{
    public class PseudoEntity
    {
        private PseudoEntity() { }

        string name = "pseudo";
        int age = 20;
        DateTime created = DateTime.Now;

        public static PseudoEntity create()
        {
            return new PseudoEntity();
        }

        public override string? ToString()
        {
            return String.Format("name {0}; age {1}; created {2};", name, age, created);
        }
    }
}
