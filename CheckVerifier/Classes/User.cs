using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVerifier.Classes
{
    class User
    {
        protected int id;
        protected short userType;
        protected short location;

        public int Id { get => id; private set => id = value; }
        public short UserType { get => userType; private set => userType = value; }
        public short Location { get => location; private set => location = value; }

        public User(int id, short userType, short location)
        {
            Id = id;
            UserType = userType;
            Location = location;
        }
    }
}
