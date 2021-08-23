﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QGameComplete
{
    public class Wall : Block
    {
        //public Image Image { get; set; }
        //public ItemType ItemType { get; set; }

        public Wall()
        {
            Image = Properties.Resources.Wall;
            ItemType = ItemType.Wall;
        }

        public Wall(Image image, ItemType itemType)
        {
            Image = image;
            ItemType = itemType;
        }
    }
}
