using System;
using Tomogatchi.Enums;
using Tomogatchi.Interfaces;
using Tomogatchi.UI;

namespace Tamagotchi.Class
{
    public class CDog : ATamagotchi, IEateable, ISleepable, IPlayable
    {
        public CDog (string name) : base(name)
        {
        }

        public void Eat()
        {
            Console.WriteLine(Messages.ACTION_FEED, Name);
            Stats.Hunger -= 30; // el -30 es porque el hambre disminuye al comer de la clase Stats
            UpdateEmotion();
            MakeSound();
        }

        public void Sleep()
        {
            Console.WriteLine(Messages.ACTION_SLEEP, Name);
            Stats.Energy += 40; // si energy por default es 50, al dormir se vuelve 90
            UpdateEmotion();
            MakeSound();
        }

        public void Play()
        {
            // If de comportamientos
            if (Emotion == EmotionState.Tired)
            {
                Console.WriteLine(Messages.TIRED_SLEEP, Name);
                Sleep();
                return;
            }

            if (Emotion == EmotionState.Angry)
            {
                Console.WriteLine(Messages.ANGRY_IGNORE, Name);
                return;
            }

            if (Emotion == EmotionState.Sad)
            {
                Console.WriteLine(Messages.SAD_REJECT, Name);
                return;
            }

            if (Emotion == EmotionState.Sick)
            {
                Console.WriteLine(Messages.SICK_NEED, Name);
                return;
            }

            Console.WriteLine(Messages.ACTION_PLAY, Name);
            Console.WriteLine(Messages.HAPPY_PLAY, Name);
            Stats.Energy -= 30;
            Stats.Hunger += 15;
            UpdateEmotion();
            MakeSound();
        }

        public override void MakeSound()
        {
            Console.WriteLine("¡Guau! soy un perro normal que habla xd 🐶");
        }
    }
}