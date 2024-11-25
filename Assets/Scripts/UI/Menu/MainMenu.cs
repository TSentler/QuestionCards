using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Menu
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        [SerializeField] private float _delay = 0.5f;
        
        private float _timeLeft;

        public void Hide()
        {
            _timeLeft = _delay;
            _canvasGroup.interactable = false;
            _canvasGroup.blocksRaycasts = false;
            StartCoroutine(HideCoroutine());
        }

        private IEnumerator HideCoroutine()
        {
            while (_timeLeft > 0f)
            {
                yield return new WaitForEndOfFrame();
                _timeLeft -= Time.deltaTime;
                _canvasGroup.alpha = Mathf.Lerp(1f, 0f, 1f - _timeLeft / _delay);
            }
        }
    }
}