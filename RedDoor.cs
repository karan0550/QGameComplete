using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGameComplete
{
    public class RedDoor : Block
    {
        public RedDoor()
        {
            Image = Properties.Resources.RedDoor;
            ItemType = ItemType.RedDoor;
        }
    }
}
