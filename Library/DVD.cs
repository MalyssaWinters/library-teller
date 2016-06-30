using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DVD : Media
    {
        public override int RentalLength
        {
            get
            {
                return 2;
            }
            //dummy set method- doesn't do anything
            set { }
        }

        public override void PrintMediaDetails()
        {
            throw new NotImplementedException();
        }

        public override DateTime ReturnDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
