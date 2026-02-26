using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class ATomogatchi
{
    public string Name { get; set; }
    public string EmotionState { get; set; }
    public int Stats { get; set; }

    public ATomogatchi(string name, string emotionState, int stats)
    {
        Name = name;
        EmotionState = emotionState;
        Stats = stats;
    }
}
 


