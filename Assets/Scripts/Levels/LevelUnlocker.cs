using System;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.Levels
{
    public class LevelUnlocker:MonoBehaviour
    {
        [SerializeField] private Button[] _buttons;
        private int _unlockedLevelNumber;

        private void Start()
        {
            if (!PlayerPrefs.HasKey("levelUnlocked"))
            {
                PlayerPrefs.SetInt("levelUnlocked",1);
            }

            _unlockedLevelNumber = PlayerPrefs.GetInt("levelUnlocked");
        }

        private void Update()
        {
            for (int i = 0; i < _buttons.Length;i++)
            {
                throw new NotImplementedException();
            }
        }
    }
}