using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Board
{
    public class CardData
    {
        public string FaceSpriteName;
        public string Name;
        public string Message;
    }
    
    public class CardViewer : MonoBehaviour
    {
        [SerializeField] private Image _face;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private TextMeshProUGUI _message;

        public void Init(Sprite face, string name, string message)
        {
            _face.sprite = face;
            _name.text = name;
            _message.text = message;
        }
    }
}
