using UnityEngine;

namespace Cards
{
    public class DealerShowedReceaver : MonoBehaviour
    {
        private Dealer _dealer;
        
        private void Awake()
        {
            _dealer = FindObjectOfType<Dealer>();
        }

        public void FirstDeal()
        {
            _dealer.Deal();
        }
    }
}
