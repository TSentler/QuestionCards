using System.Collections.Generic;
using Cards;
using Infrastructure.StaticData;
using UnityEngine;

namespace UI.Board
{
    public class CardsSpawner : MonoBehaviour
    {
        [SerializeField] private Transform _cardsParent;
        [SerializeField] private GameObject _cardPrefab;
    
        private List<GameObject> _cards = new List<GameObject>();
        private CardsContainer _cardsContainer;

        private void Awake()
        {
            foreach (Transform child in _cardsParent)
            {
                Destroy(child.gameObject);
            }
            CardsInfoLoader cardsInfoLoader = new CardsInfoLoader();
            _cardsContainer = cardsInfoLoader.Load();
        }

        public void Add()
        {
            GameObject card = Instantiate(_cardPrefab, _cardsParent);
            _cards.Add(card);
            
            CardData cardData = _cardsContainer.GetRandomCard();
            
            CardViewer cardViewer = card.GetComponent<CardViewer>();
            cardViewer.Init(cardData);
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
