using System;
using Newtonsoft.Json;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameState: MonoBehaviour
    {
        [SerializeField] private int _ticketCount;
        
        public int Ticket { get; set; }
        public int Day { get; set; }
        public int Level { get; set; }

        private void Start()
        {
            _ticketCount = 1000;
        }

        private PlayerPrefs _tickets = new PlayerPrefs();
        private PlayerPrefs _days = new PlayerPrefs();
        private PlayerPrefs _level = new PlayerPrefs();
        
    }
}