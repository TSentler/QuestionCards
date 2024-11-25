using UnityEngine;

namespace UI.Menu
{
    public class PlayGame : MonoBehaviour
    {
        private MainMenu _mainMenu;
        private Jalousie _jalousie;

        private void Awake()
        {
            _jalousie = FindObjectOfType<Jalousie>();
            _mainMenu = FindObjectOfType<MainMenu>();
        }

        public void Play()
        {
            _jalousie.Open();
            _mainMenu.Hide();
        }
    }
}
