using TMPro;
using UnityEngine;

namespace TicketBase
{
    public class RewardUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _dayNumberLabel;
        [SerializeField] private TextMeshProUGUI _amountLabel;

        public TextMeshProUGUI DayNumberLabel => _dayNumberLabel; 
        public TextMeshProUGUI AmountLabel => _amountLabel;
    }
}