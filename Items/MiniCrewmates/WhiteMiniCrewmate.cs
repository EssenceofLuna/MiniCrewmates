﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCrewmates.Items
{
    class WhiteMiniCrewmate : CyanMiniCrewmate
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("White Mini Crewmate");
        }
    }
}