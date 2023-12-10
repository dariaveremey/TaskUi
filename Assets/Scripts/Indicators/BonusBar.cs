using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Indicators
{
    public class BonusBar : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private float _maxValue;
        [SerializeField] private float _minValue;
        [SerializeField] private TextMeshProUGUI _currentValue;

        private void Start()
        {
            _slider.minValue = _minValue;
            _slider.maxValue = _maxValue;
            _slider.value = 2;
            _currentValue.text = $"{_slider.value}/{_maxValue}";

        }

   
    }
    }
