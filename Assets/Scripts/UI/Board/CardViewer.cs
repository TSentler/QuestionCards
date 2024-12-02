using Infrastructure.StaticData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Board
{
    public class CardViewer : MonoBehaviour
    {
        [SerializeField] private Image _face;
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private Image _death;

        public void Init(CardData cardData)
        {
            _name.text = cardData.Name;
            _face.sprite = cardData.Face;
            _death.sprite = cardData.Death;
        }
    }
}
