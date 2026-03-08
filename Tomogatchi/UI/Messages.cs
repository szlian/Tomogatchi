using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogatchi.UI
{
    public static class Messages
    {
        // El welcoming xd
        public const string WELCOME = "-------TAMAGOTCHI-------";
        public const string CHOOSE_PED = "CHOOSE YOUR PET";
        public const string OPTION_CAT = "1. CAT";
        public const string OPTION_DOG = "2. DOG";
        public const string OPTION_CHICK = "3. CHICK";
        public const string ENTER_NAME = "ESCRIBE EL NOMBRE DE SU MASCOTA";


        // Menú principal
        public const string MENU_TITLE = "\n--- MENÚ ---";
        public const string MENU_FEED = "1. Alimentar";
        public const string MENU_SLEEP = "2. Dormir";
        public const string MENU_PLAY = "3. Jugar";
        public const string MENU_STATUS = "4. Ver estado";
        public const string MENU_EXIT = "5. Salir";
        public const string CHOOSE_OPTION = "Elige una opción:";


        // Mensajes de acciones
        public const string ACTION_FEED = "Alimentando a {0}...";
        public const string ACTION_SLEEP = "{0} está durmiendo...";
        public const string ACTION_PLAY = "Jugando junto a {0}...";


        // Mensajes de emociones
        public const string EMOTION_HAPPY = "{0} está feliz! :)";
        public const string EMOTION_SAD = "{0} está triste... :(";
        public const string EMOTION_ANGRY = "{0} está enfadado! >:(";
        public const string EMOTION_TIRED = "{0} tiene sueño... zZz";
        public const string EMOTION_SICK = "{0} está enfermo! Necesita una inyección!";


        // Mensajes de comportamiento según emoción
        public const string HAPPY_PLAY = "¡{0} quiere jugar contigo!";
        public const string SAD_REJECT = "{0} no quiere jugar, está triste...";
        public const string ANGRY_IGNORE = "{0} te ignora, está muy enfadado.";
        public const string TIRED_SLEEP = "{0} se quedó dormido en medio del juego!";
        public const string SICK_NEED = "¡{0} necesita atención médica urgente!";


        // Mensajes de estadísticas
        public const string STATS_HUNGER = "Hambre: {0}/100";
        public const string STATS_ENERGY = "Energía: {0}/100";
        public const string STATS_HEALTH = "Salud: {0}/100";
        public const string STATS_EMOTION = "Estado: {0}";

        // Mensajes de errores y avisos
        public const string INVALID_OPTION = "Opción no válida. Intenta de nuevo.";
        public const string PET_DEAD = "{0} ha muerto... :'(";
        public const string LOW_HUNGER = "¡{0} tiene mucha hambre!";
        public const string LOW_ENERGY = "¡{0} está muy cansado!";

        // Mensajes de items
        public const string INVENTORY_EMPTY = "No tienes items en el inventario.";
        public const string ITEM_USED = "Has usado {0} en {1}.";
        public const string ITEM_ADDED = "Has puesto {0} al inventario.";

    }

}
