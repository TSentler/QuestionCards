using System.Collections.Generic;
using UnityEngine;

namespace UI.Board
{
    public class CardsSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _cardsParent;
        [SerializeField] private GameObject _cardPrefab;
    
        private List<GameObject> _cards = new List<GameObject>();

        private void Awake()
        {
            foreach (Transform child in _cardsParent)
            {
                Destroy(child.gameObject);
            }
        }

        public void Add()
        {
            GameObject card = Instantiate(_cardPrefab, _cardsParent);
            _cards.Add(card);
        }

        public void Clear()
        {
            foreach (GameObject card in _cards)
            {
                Destroy(card);
            }
            _cards.Clear();
        }
    }
}
