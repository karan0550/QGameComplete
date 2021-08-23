using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGameComplete
{
    class Tile : PictureBox
    {
        public int ROW { get; set; }
        public int COLUMN { get; set; }
        public ItemType itemType { get; set; }
    }
}
