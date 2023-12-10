using DefaultNamespace.Play;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.Shop
{
    public class ShopUI:MonoBehaviour
    {
        [SerializeField] private AudioSourceGame _audioSource;
        [SerializeField] private Button _button;

        private void Start()
        {
            _button.onClick.AddListener(_audioSource.Play);
        }
    }
}