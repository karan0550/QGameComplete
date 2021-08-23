using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGameComplete
{
    public class GreenDoor : Block
    {
        public GreenDoor()
        {
            Image = Properties.Resources.GreenDoor;
            ItemType = ItemType.GreenDoor;
        }
    }
}
