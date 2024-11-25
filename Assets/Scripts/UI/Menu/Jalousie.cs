using UnityEngine;
using UnityEngine.Playables;

namespace UI.Menu
{
    public class Jalousie : MonoBehaviour
    {
        [SerializeField] private PlayableDirector _playableDirector;
        
        public void Open()
        {
            _playableDirector.Play();
        }
    }
}
