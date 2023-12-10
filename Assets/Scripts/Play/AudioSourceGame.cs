using UnityEngine;

namespace DefaultNamespace.Play
{
    public class AudioSourceGame:MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;

        public void Play()
        {
            _audioSource.Play();
        }
    }
}