 using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace circle_and_coin
{
        class Coin : Circle
        {
            public double weight;
            public double propweight
            {
                set { weight = value; }
                get { return weight; }

            }
            public Coin() : base()
            {
                weight = 0;
            }
            public Coin(double rad, double w) 
            {
                weight = w;
            }
            public string getCoinValue()
            {
            string CoinValue = "";
                if (weight == 5 && Radius == 5)
                
                 CoinValue = "10c";

                else if (weight == 10 && Radius == 10)
                {
                CoinValue = "5c";
                }
                else if (weight == 5 && Radius == 10)
                {
                CoinValue = "R1";
                }
                else if (weight == 8 && Radius == 7)
                {
                CoinValue = "R2";
                }
                else if (weight == 15 && Radius == 15)
                {
                CoinValue = "R5"; 
                }
            return CoinValue;
            }

        }
    
}


           










