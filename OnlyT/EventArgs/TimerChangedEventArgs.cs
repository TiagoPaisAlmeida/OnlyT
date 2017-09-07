﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyT.EventArgs
{
   public class TimerChangedEventArgs : System.EventArgs
   {
      public int TargetSecs { get; set; }
      public int ElapsedSecs { get; set; }
      public int RemainingSecs => TargetSecs - ElapsedSecs;
   }
}