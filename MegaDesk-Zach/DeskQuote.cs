using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Zach
{
    // Display quote information after adding one through AddQuote form.
    public class DeskQuote 
    {
        public string  CustomerName;
        public Desk            Desk;
        public int       Speed = 14;

        public DeskQuote(string customerName, int speed, Desk desk)
        {
            CustomerName = customerName;
            Desk         =         desk;
            Speed        =        speed;
        }


        private int GetRushCost(int surfaceArea)
        {
            if (this.Speed < 14)
            {

                Dictionary<int, int[]> pricingTable = new()
                {
                    {3, new int[] {60,70,80} },
                    {5, new int[] {40,50,60} },
                    {7, new int[] {30,35,40} }
                };

                int sizeIndex = surfaceArea / 1000;

                if (sizeIndex > 2)
                    sizeIndex = 2;

                return pricingTable[this.Speed][sizeIndex];
            }
            else
            {
                return 0;
            }
        }

        public int GetPrice()
        {
            int baseCost = 200;
            int drawerCost = 50 * Desk.Drawers;
            int area = Desk.GetArea();
            int surfaceCost = 0;

            if (area > 1000)
                surfaceCost = area - 1000;

            int materialCost = Desk.GetMaterialCost();
            int rushCost = GetRushCost(surfaceCost);

            return baseCost + drawerCost + surfaceCost + materialCost;
        }

        public override string ToString()
        {
            return "$" + GetPrice().ToString();
        }

    }
}
