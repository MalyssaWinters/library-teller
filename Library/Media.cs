﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    abstract class Media
    {
        public virtual string Title { get;  set; }
        public virtual string Length { get;  set; }
        //abstract means Book, Magainze and DVD all need to have a RentalLength
        public abstract int RentalLength { get; set; }
        protected DateTime RentedDate { get;  set; }
    
        
        public Media()
        {
            RentedDate = DateTime.Today;
        }
        
        public abstract void PrintMediaDetails();

        public abstract DateTime ReturnDueDate();

        public virtual void  SetRentedDate()
        {
            RentedDate = DateTime.Today;
        }
    }
}
