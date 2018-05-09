using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVerifier.Classes
{
    class Stamp
    {
        DateTime date;
        TimeSpan checkinTime;
        TimeSpan checkoutTime;
        short flags;
        float flex;

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan CheckinTime { get => checkinTime; set => checkinTime = value; }
        public TimeSpan CheckoutTime { get => checkoutTime; set => checkoutTime = value; }
        public short Flags { get => flags; set => flags = value; }
        public float Flex { get => flex; set => flex = value; }

        public Stamp(DateTime date, short flags)
        {
            Date = date;
            Flags = flags;
        }

        public Stamp(DateTime date, TimeSpan checkinTime, short flags)
        {
            Date = date;
            CheckinTime = checkinTime;
            Flags = flags;
            Flex = 0;
        }

        public Stamp(DateTime date, TimeSpan checkinTime, TimeSpan checkoutTime, short flags, float flex)
        {
            Date = date;
            CheckinTime = checkinTime;
            CheckoutTime = checkoutTime;
            Flags = flags;
            Flex = flex;
        }
    }
}
