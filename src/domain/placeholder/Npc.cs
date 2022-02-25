using System;
using System.Collections.Generic;
using domain.common;
using domain.player;

namespace domain.placeholder
{
    public class Npc : Character
    {
        public Npc(string name, string description)
        {
            Name = name;
            Description = description;
            Inventory = new List<Item>();

            Dialogues = new Dictionary<NpcLinesEnum, string> 
            {
                { NpcLinesEnum.Greetings, NpcLines.Greetings },
                { NpcLinesEnum.Goodbye, NpcLines.Goodbye }
            };
            Responses = new Dictionary<PlayerLinesEnum, NpcLinesEnum>
            {
                { PlayerLinesEnum.Greetings, NpcLinesEnum.Greetings },
                { PlayerLinesEnum.Goodbye, NpcLinesEnum.Goodbye }
            };
        }

        public IDictionary<NpcLinesEnum, string> Dialogues { get; set; }
        public IDictionary<PlayerLinesEnum, NpcLinesEnum> Responses { get; set; }

        public void Converse(PlayerLinesEnum playerLine)
        {
            var npcLine = Responses[playerLine];
            var dialogue = Dialogues[npcLine];
            Console.WriteLine(dialogue);
        }
    }
}
