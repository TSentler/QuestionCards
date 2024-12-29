using UnityEngine;

namespace Cards
{
    [RequireComponent(typeof(CardsSpawner))]
    public class Dealer : MonoBehaviour
    {
        [SerializeField] private Transform _cardsParent;
        [SerializeField] private int _cardsAmount = 1;
        
        private CardsSpawner _cardsSpawner;
        
        private void Awake()
        {
            _cardsSpawner = GetComponent<CardsSpawner>();
            _cardsSpawner.Prepare(_cardsParent);
        }

        public void Deal()
        {
            for (int i = 0; i < _cardsAmount; i++)
            {
                _cardsSpawner.Add();
            }
        }
    }
}
