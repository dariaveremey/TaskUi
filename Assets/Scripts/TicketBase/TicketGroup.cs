using System.Collections.Generic;
using UnityEngine;

namespace TicketBase
{
    public class TicketGroup : MonoBehaviour
    {
        [SerializeField] private RewardsDatabase _rewardsDatabase;
        [SerializeField] private GameObject _rewardPrefab;

        private RectTransform _rectTransform;
        private List<GameObject> _cells = new();
        private List<RewardsDatabase> _rewardsDatabases;
        private Dictionary<int, int> _dictionary;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            CreateNewCells(_rewardsDatabase.RewardsCount);
        }

        private void CreateNewCells(int hp)
        {
            for (int i = 0; i < hp - 1; i++)
            {
                if (_rectTransform != null)
                {
                    GameObject cell = Instantiate(_rewardPrefab, _rectTransform);
                    cell.GetComponent<RewardUI>().DayNumberLabel.text =
                        cell.GetComponent<RewardUI>().DayNumberLabel.text +
                        _rewardsDatabase.GetDayNumber(i).ToString();
                    cell.GetComponent<RewardUI>().AmountLabel.text = _rewardsDatabase.GetDayValue(i).ToString();
                    _cells.Add(cell);
                }
            }
        }
    }
}