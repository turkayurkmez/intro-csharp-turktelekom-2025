using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypes
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public override bool Equals(object? obj)
        {

            if (obj == null) return false;

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Money that = (Money)obj;

            return (this.Currency == that.Currency && that.Amount == this.Amount);
           




        }
    }

    public record RecordMoney
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }
}
