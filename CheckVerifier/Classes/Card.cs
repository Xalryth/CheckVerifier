using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVerifier.Classes
{
    class Card
    {
        string cardid;
        short cardType;
        DateTime creationDate;
        DateTime expirationDate;

        public string Cardid { get => cardid; set => cardid = value; }
        public short CardType { get => cardType; set => cardType = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public Card(string cardid, short cardType, DateTime creationDate, DateTime expirationDate)
        {
            Cardid = cardid;
            CardType = cardType;
            CreationDate = creationDate;
            ExpirationDate = expirationDate;
        }
    }
}
