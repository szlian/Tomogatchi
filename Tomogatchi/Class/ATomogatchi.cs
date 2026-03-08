using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomogatchi.Class;
using Tomogatchi.Enums;
using Tomogatchi.UI;

namespace Tamagotchi.Class
{
    public abstract class ATamagotchi
    {
        public string Name { get; set; }
        public EmotionState Emotion { get; set; }
        public Stats Stats { get; set; }

        protected ATamagotchi(string name)
        {
            Name = name;
            Emotion = EmotionState.Happy;
            Stats = new Stats();
        }

        // Actualiza el estado emocional según las estadísticas
        public void UpdateEmotion()
        {
            if (Stats.IsDead)
            {
                return;
            }

            if (Stats.Health <= 20)
            {
                Emotion = EmotionState.Sick;
                Console.WriteLine(Messages.EMOTION_SICK, Name);
            }
            else if (Stats.Energy <= 30)
            {
                Emotion = EmotionState.Tired;
                Console.WriteLine(Messages.EMOTION_TIRED, Name);
            }
            else if (Stats.Hunger >= 50)
            {
                Emotion = EmotionState.Angry;
                Console.WriteLine(Messages.EMOTION_ANGRY, Name);
            }
            else if (Stats.Hunger >= 30)
            {
                Emotion = EmotionState.Sad;
                Console.WriteLine(Messages.EMOTION_SAD, Name);
            }
            else
            {
                Emotion = EmotionState.Happy;
                Console.WriteLine(Messages.EMOTION_HAPPY, Name);
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine("\n--- ESTADO DE " + Name.ToUpper() + " ---");
            Console.WriteLine(Messages.STATS_EMOTION, Emotion);
            Stats.ShowStats();
        }

        // Método abstracto para hacer sonido (cada mascota lo implementa diferente)
        public abstract void MakeSound();
    }
}


