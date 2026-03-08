using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogatchi.Class
{   public class CCats : ATomogatchi
    {
        public CCats(string name, int stats, string emotionState = "Happy") : base(name, emotionState, stats)
        {

        }
    }
}
