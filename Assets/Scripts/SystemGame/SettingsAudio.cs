using UnityEngine;
using UnityEngine.UI;

namespace SystemGame
{
    public class SettingsAudio : MonoBehaviour
    {
        [SerializeField] private GameObject _settingView;
        [SerializeField] private Button _settingButton;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Button _onAudioSource;
        [SerializeField] private Button _offAudioSource;

        private void Awake()
        {
            _settingView.SetActive(false);
        }

        private void Start()
        {
            _settingButton.onClick.AddListener(Play);
            _settingButton.onClick.AddListener(OpenSettingsMenu);
            _onAudioSource.onClick.AddListener(SwitchOnAudio);
            _offAudioSource.onClick.AddListener(SwitchOffAudio);
        }

        private void OpenSettingsMenu()
        {
            _settingView.SetActive(true);
        }
        
        private void Play()
        {
           _audioSource.Play();
        }

        private void SwitchOnAudio()
        {
            AudioListener.volume = 1;
        }

        private void SwitchOffAudio()
        {
            AudioListener.volume = 0;
        }
    }
}