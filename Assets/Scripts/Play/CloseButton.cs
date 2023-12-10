using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.Play
{
    public class CloseButton:MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _gameObject;

        private void Start()
        {
            _button.onClick.AddListener(Close);
        }

        private void Close()
        {
            _gameObject.SetActive(false);
        }
        
    }
}