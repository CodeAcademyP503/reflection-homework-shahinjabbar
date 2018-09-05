using InfaTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies
{
    public class Card : Entity<Card>
    {
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public bool IsUsed { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public AppUser ActivatedBy { get; set; }
        public int ActivatedById { get; set; }
        public DateTime AddedDate { get; set; }

        public override bool Equals(object obj)
        {
            Card card = obj as Card;
            if (card.Number == this.Number)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Update(Card card)
        {
            this.ActivatedBy = card.ActivatedBy;
            this.ActivatedById = card.ActivatedById;
            this.ActivatedDate = card.ActivatedDate;
            this.AddedDate = card.AddedDate;
            this.Balance = card.Balance;
            this.CurrencyType = card.CurrencyType;
            this.IsUsed = card.IsUsed;
            this.Number = card.Number;
        }
        
    }
}


