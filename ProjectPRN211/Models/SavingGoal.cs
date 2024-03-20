using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN211.Models
{
    internal class SavingGoal
    {
        public int GoalId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public decimal TargetAmount { get; set; }
        public decimal CurrentAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SavingGoal(int goalId, string username, string name, decimal targetAmount, decimal currentAmount, DateTime startDate, DateTime endDate)
        {
            GoalId = goalId;
            Username = username;
            Name = name;
            TargetAmount = targetAmount;
            CurrentAmount = currentAmount;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
