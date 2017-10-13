using System.Collections.Generic;

namespace Monkeys
{
    internal class Bridge
    {
        private int _count;

        public List<Monkey> LeftStart { get; set; }
        public List<Monkey> RightStart { get; set; }
        public List<Monkey> RightEnd { get; private set; }
        public List<Monkey> LeftEnd { get; private set; }

        public void CrossTheBridge(List<Monkey> leftStart, List<Monkey> rightStart)
        {

        }
    }
}
