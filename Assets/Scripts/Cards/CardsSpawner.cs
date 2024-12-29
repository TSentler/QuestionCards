using System.Collections.Generic;
using Infrastructure.AssetManagement;
using Infrastructure.StaticData;
using UI.Board;
using UnityEngine;

namespace Cards
{
    public class CardsSpawner : MonoBehaviour
    {
        private Transform _cardsParent;
        private List<GameObject> _cards = new List<GameObject>();
        private CardsContainer _cardsContainer;
        private AssetProvider _assetProvider;

        public void Prepare(Transform cardsParent)
        {
            _cardsParent = cardsParent;
            foreach (Transform child in _cardsParent)
            {
                Object.Destroy(child.gameObject);
            }
            CardsInfoLoader cardsInfoLoader = new CardsInfoLoader();
            _cardsContainer = cardsInfoLoader.Load();
            _assetProvider = new AssetProvider();
        }

        public void Add()
        {
            GameObject card = _assetProvider.Instantiate(AssetsPath.CardPrefab, _cardsParent);
            _cards.Add(card);
            
            CardData cardData = _cardsContainer.GetRandomCard();
            
            CardViewer cardViewer = card.GetComponent<CardViewer>();
            cardViewer.Init(cardData);
        }

        public void Clear()
        {
            foreach (GameObject card in _cards)
            {
                Object.Destroy(card);
            }
            _cards.Clear();
        }
    }
}
