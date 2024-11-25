using UnityEngine;

namespace UI.Menu
{
    public class PlayGame : MonoBehaviour
    {
        private Jalousie _jalousie;

        private void Awake()
        {
            _jalousie = FindObjectOfType<Jalousie>();
        }

        public void Play()
        {
            _jalousie.Open();
        }
    }
}
