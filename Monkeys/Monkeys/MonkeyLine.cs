using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys
{
    class MonkeyLine
    {
        public string Name { get; set; }
        public int Count { get { return Monkeys.Count; } }

        private List<Monkey> _monkeys = new List<Monkey>();
        public List<Monkey> Monkeys
        {
            get { return _monkeys; }
            set { _monkeys = value; }
        }

    }
}
