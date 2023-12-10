using System.Collections.Generic;
using UnityEngine;

namespace TicketBase
{
    [CreateAssetMenu(fileName = "RewardDataBase", menuName = "DailyRewardsSystem")]
    public class RewardsDatabase : ScriptableObject
    {
        public List<RewardBase> Tickets;

        public int RewardsCount => Tickets.Count;

        public int GetDayNumber(int index)
        {
            return Tickets[index].DayNumber;
        }

        public int GetDayValue(int index)
        {
            return Tickets[index].TicketValue;
        }
    }
}