using System.IO;
using Infrastructure.AssetManagement;
using UnityEngine;

namespace Infrastructure.StaticData
{
    public class CardData
    {
        public string Name;
        public Sprite Face;
        public Sprite Death;
        
        public CardData(string name, string face, string death)
        {
            Name = name;
            Face = Resources.Load<Sprite>(Path.Combine(AssetsPath.FacePath, face));
            Death = Resources.Load<Sprite>(Path.Combine(AssetsPath.DeathPath, death));
            Debug.Log(Path.Combine(AssetsPath.FacePath, face));
            Debug.Log(Path.Combine(AssetsPath.DeathPath, death));
        }
    }
}