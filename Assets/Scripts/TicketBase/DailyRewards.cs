using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicketBase
{
    public class DailyRewards : MonoBehaviour

    {
        //[SerializeField] private GameObject _rewardNotification;
        [SerializeField] private GameObject _weeklyNotification;
        [SerializeField] private Button _giftButton;
        [SerializeField] private AudioSource _audioSource;
        
        private void Awake()
        {
//            _rewardNotification.SetActive(false);
            _weeklyNotification.SetActive(false);
        }

        private void Start()
        {
            _giftButton.onClick.AddListener(Play);
            _giftButton.onClick.AddListener(GivePresent);
        }

        private void GivePresent()
        {
            _weeklyNotification.SetActive(true);
        }
        
        private void Play()
        {
            _audioSource.Play();
        }
    }
}

