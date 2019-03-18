using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Team
    {
        Asker[] troops_1 = new Asker[7];
        Asker[] troops_2 = new Asker[7];
        public Asker[] Troops_1 { get { return troops_1; } set { troops_1 = value; } }
        public Asker[] Troops_2 { get { return troops_2; } set { troops_2 = value; } }

        //Determining troops
        public Team()
            {
            //First 4 soldiers of Troops_1 are determining as Pvt.
            for (int i=0; i<4; i++)
                {
                    this.Troops_1[i] = new Er();
                }
            //5th and 6th soldiers are determining as Lt.
                this.Troops_1[4] = new Tegmen();
                this.Troops_1[5] = new Tegmen();
            //7th soldier is determining as Cpt.
                this.Troops_1[6] = new Yuzbasi();

                foreach(Asker item in Troops_1)
                {
                    item.Team = 1;
                }

            //First 4 soldiers of Troops_2 are determining as Pvt.
            for (int i=0; i<4; i++)
                {
                    this.Troops_2[i] = new Er();
                }
            //5th and 6th soldiers are determining as Lt.
                this.Troops_2[4] = new Tegmen();
                this.Troops_2[5] = new Tegmen();
            //7th soldier is determining as Cpt.
                this.Troops_2[6] = new Yuzbasi();

                foreach(Asker item in Troops_2)
                {
                    item.Team = 2;
                }
            }
        }
    }
}
