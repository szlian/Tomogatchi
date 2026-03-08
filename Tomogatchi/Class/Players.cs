using System;
using System.Collections.Generic;
using Tomogatchi.UI;

namespace Tamagotchi.Class
{
    public class Player
    {
        public string Name { get; set; }
        public List<string> Inventory { get; set; }
        public ATamagotchi MyPet { get; set; }

        public Player(string name)
        {
            Name = name;
            Inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            Inventory.Add(item);
            Console.WriteLine(Messages.ITEM_ADDED, item);
        }

        public void UseItem(string item)
        {
            if (Inventory.Contains(item))
            {
                Inventory.Remove(item);
                Console.WriteLine(Messages.ITEM_USED, item, MyPet.Name);

                // Efecto del item
                if (item == "Comida")
                {
                    MyPet.Stats.Hunger -= 20;
                    Console.WriteLine("El hambre de {0} ha bajado.", MyPet.Name);
                }
                else if (item == "Medicina")
                {
                    MyPet.Stats.Hunger = 30;
                    MyPet.Stats.Energy = 60;
                    Console.WriteLine("¡{0} se ha curado!", MyPet.Name);
                }
                else if (item == "Juguete")
                {
                    MyPet.Stats.Energy += 20;
                    Console.WriteLine("La energía de {0} subió.", MyPet.Name);
                }

                MyPet.UpdateEmotion();
            }
            else
            {
                Console.WriteLine(Messages.INVENTORY_EMPTY);// Mensaje de inventario vacío en UI
            }
        }

        public void ShowInventory()
        {
            if (Inventory.Count == 0)
            {
                Console.WriteLine(Messages.INVENTORY_EMPTY);
                return;
            }

            Console.WriteLine("\n--- INVENTARIO ---");
            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Inventory[i]);
            }
        }
    }
}