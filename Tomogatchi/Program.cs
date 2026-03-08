using System;
using Tamagotchi.Class;
using Tomogatchi.Interfaces;
using Tomogatchi.UI;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Messages.WELCOME);
            Console.WriteLine(Messages.CHOOSE_PET);
            Console.WriteLine(Messages.OPTION_CAT);
            Console.WriteLine(Messages.OPTION_DOG);
            Console.WriteLine(Messages.OPTION_CHICK);

            ATamagotchi myPet = null;
            int choice = 0;

            // Validar entrada
            while (choice < 1 || choice > 3)
            {
                Console.Write(Messages.CHOOSE_OPTION);
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine(Messages.INVALID_OPTION);
                }
            }

            Console.WriteLine(Messages.ENTER_NAME);
            string petName = Console.ReadLine();

            // Crear la mascota según la elección
            switch (choice)
            {
                case 1:
                    myPet = new CCat(petName);
                    break;
                case 2:
                    myPet = new CDog(petName);
                    break;
                case 3:
                    myPet = new CChicks(petName);
                    break;
            }

            Player player = new Player("Jugador");
            player.MyPet = myPet;

            // Añadir items iniciales
            player.AddItem("Comida");
            player.AddItem("Medicina");

            Console.WriteLine("\n¡Bienvenido {0}!", player.Name);
            myPet.MakeSound();

            // Bucle principal del juego
            bool playing = true;
            while (playing && !myPet.Stats.IsDead)
            {
                Console.WriteLine(Messages.MENU_TITLE);
                Console.WriteLine(Messages.MENU_FEED);
                Console.WriteLine(Messages.MENU_SLEEP);
                Console.WriteLine(Messages.MENU_PLAY);
                Console.WriteLine(Messages.MENU_STATUS);
                Console.WriteLine(Messages.MENU_EXIT);

                Console.Write(Messages.CHOOSE_OPTION);
                string option = Console.ReadLine();

                // Verificar si la mascota está muerta antes de cada acción
                if (myPet.Stats.IsDead)
                {
                    Console.WriteLine(Messages.PET_DEAD, myPet.Name);
                    break;
                }

                switch (option)
                {
                    case "1": // Alimentar
                        // Verificar si puede comer
                        if (myPet is IEateable eatablePet)
                        {
                            eatablePet.Eat();
                        }
                        else
                        {
                            Console.WriteLine("{0} no puede comer.", myPet.Name);
                        }
                        break;

                    case "2": // Dormir
                        // Verificar si puede dormir
                        if (myPet is ISleepable sleepablePet)
                        {
                            sleepablePet.Sleep();
                        }
                        else
                        {
                            Console.WriteLine("{0} no puede dormir.", myPet.Name);
                        }
                        break;

                    case "3": // Jugar
                        // Verificar si puede jugar (usando Interface Segregation)
                        if (myPet is IPlayable playablePet)
                        {
                            playablePet.Play();
                        }
                        else
                        {
                            Console.WriteLine("{0} no quiere jugar ahora.", myPet.Name);
                        }
                        break;

                    case "4": // Ver estado
                        myPet.ShowStatus();
                        player.ShowInventory();
                        break;

                    case "5": // Salir
                        playing = false;
                        Console.WriteLine("¡Adiós! Cuida bien de {0}.", myPet.Name);
                        break;

                    default:
                        Console.WriteLine(Messages.INVALID_OPTION);
                        break;
                }

                // Verificar si murió después de la acción
                if (myPet.Stats.IsDead)
                {
                    Console.WriteLine(Messages.PET_DEAD, myPet.Name);
                    playing = false;
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}