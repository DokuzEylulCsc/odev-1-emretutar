using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Ermeydani
    {
        Bolge[,] harita = new Bolge[16, 16];

        public Bolge[,] Harita { get { return harita; } set { harita = value; } }
        //Accessing the troops
        public Team Teams_of_War;
        //Controlling the area
        public bool Control;

        //16 squares on the area are determining
        public Ermeydani(Team Team_Square)
        {
            for(int i=0; i<16; i++)
            {
                for(int j=0; j<16; j++)
                {
                    Harita[i, j] = new Bolge(i,j);
                }
            }
            Teams_of_War = Team_Square;
        }

    }
}
