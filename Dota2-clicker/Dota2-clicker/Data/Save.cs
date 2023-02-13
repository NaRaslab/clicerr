using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota2_clicker.Data
{
    internal class Save : MainPage
    {
        

        public double Gold 
        { 
            get
            {
                return SaveGold;
            }
            set
            {
                Gold = value;
            }
        }
    }
}
