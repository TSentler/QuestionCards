using System;
using System.Collections.Generic;

namespace Infrastructure.StaticData
{
    [Serializable]
    public class CardsContainer
    {
        public List<string> Names = new List<string>();
        public List<string> Deaths = new List<string>();
        public List<string> Face = new List<string>();

        public CardData GetRandomCard()
        {
            string name = Names[new Random().Next(0, Names.Count)];
            string death = Deaths[new Random().Next(0, Deaths.Count)];
            string face = Face[new Random().Next(0, Face.Count)];
            return new CardData(name, death, face);
        }
    }
}