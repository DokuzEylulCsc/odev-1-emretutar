using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat
        {
            get
            {
                return koordinat;
            }
        }

        public Ermeydani Movement_Control;
        public bool Alive = true;
        public int Life_Points = 100;
        public int Damage;
        public int Team;
        
        public abstract void HaraketEt();
        public abstract void Bekle();
        public abstract void AtesEt();
    }
}
