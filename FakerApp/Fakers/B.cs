using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakers
{
    public class B
    {
        public int integerValue;
        public DateTime DateTimeValue;
        public B du;
        public List<string> ListValue;
        public C CValue;
        public B()
        {

        }

        public B(int intValue)
        {
            integerValue = intValue;
        }
    }
}
