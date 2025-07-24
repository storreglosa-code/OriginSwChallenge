using System;
using OriginBank.Domain.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginBank.Domain.Entities
{
    public class Transaction
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
