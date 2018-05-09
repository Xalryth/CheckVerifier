using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVerifier
{
    class DAL
    {
        private DAL instance;

        public DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }

        private DAL() { }

        //functions

        //check expirationdate
        //create new timestamp
        //finish timestamp
        //get user
        //update timestamp
    }
}
