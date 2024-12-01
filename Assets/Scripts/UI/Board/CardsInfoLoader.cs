using System.IO;
using UnityEngine;
using Infrastructure.AssetManagement;

namespace UI.Board
{
    
    
    public class CardsInfoLoader : MonoBehaviour
    {
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

        private void Awake()
        {
            TextAsset textAsset = Resources.Load<TextAsset>(AssetsPath.CardsData);
            CardData cardData = JsonUtility.FromJson<CardData>(textAsset.text);
            Debug.Log(textAsset.text);
            cardData.Name = Random.Range(0, 100).ToString();
            WriteData(cardData);
        }

        private void WriteData(CardData cardData)
        {
            string savePlayerData = JsonUtility.ToJson(cardData);
            File.WriteAllText(SaveFilePath, savePlayerData);
  
            
            Debug.Log("Save file created at: " + SaveFilePath);
        }
    }
}
