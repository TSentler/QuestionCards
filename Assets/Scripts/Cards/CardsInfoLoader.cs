using System.IO;
using Infrastructure.AssetManagement;
using Infrastructure.StaticData;
using UnityEngine;

namespace Cards
{
    public class CardsInfoLoader
    {
        private CardsContainer _cardsContainer;
        
        private string SaveFilePath
        {
            get
            {
                string path = Path.Combine(Application.persistentDataPath, AssetsPath.CardsData + ".json");
#if UNITY_EDITOR
                path = Path.Combine(Application.dataPath, "Resources", AssetsPath.CardsData + ".json");
#endif
                return path;
            }
        }

        public CardsContainer Load()
        {
            TextAsset textAsset = Resources.Load<TextAsset>(AssetsPath.CardsData);
            _cardsContainer = JsonUtility.FromJson<CardsContainer>(textAsset.text);
            return _cardsContainer;
        }

        private void AddTestData()
        {
            if (_cardsContainer.Names.Count == 0)
            {
                _cardsContainer.Names.Add("Вася");
                _cardsContainer.Names.Add("");
                _cardsContainer.Deaths.Add("Утонул");
                _cardsContainer.Face.Add("Вумен");
                Debug.Log("Cards added");
            }

            _cardsContainer.Names[1] = Random.Range(0, 100).ToString();
        }

        private void WriteData()
        {
            string savePlayerData = JsonUtility.ToJson(_cardsContainer);
            Debug.Log(savePlayerData);
            File.WriteAllText(SaveFilePath, savePlayerData);
            Debug.Log("Save file created at: " + SaveFilePath);
        }
    }
}
