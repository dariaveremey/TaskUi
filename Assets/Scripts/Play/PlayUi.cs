using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.Play
{
    public class PlayUi:MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private AudioSource _audioSource;

        private void Start()
        {
            _playButton.onClick.AddListener(Play);
        }

        private void Play()
        {
            _audioSource.Play();
        }
    }
}