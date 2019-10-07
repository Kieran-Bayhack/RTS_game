using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Game
{
    abstract class Unit
    {
        protected int x;
        protected int y;
        protected int health;
        protected int maxHealth;
        protected int speed;
        protected int atk;
        protected int atkRange;
        protected int team;
        protected String symb;

        //parent class attributes
        //protected

        

        public abstract int X
        {
            get;
            set;
        }

        public abstract int Y
        {
            get;
            set;
        }

        public abstract int Health
        {
            get;
            set;
        }

        public abstract int MaxHealth
        {
            get;
            
        }

        public abstract int Speed
        {
            get;
            set;
        }

        public abstract int Atk
        {
            get;
            set;
        }

        public abstract int AtkRange
        {
            get;
            set;
        }

        public abstract int Team
        {
            get;
            set;
        }

        public abstract String Symbol
        {
            get;
            set;
        }

        public abstract void Move(ref Unit closestUnit);
        public abstract void Combat(ref Unit attacker);
        public abstract bool inRange(ref Unit attacker);
        public abstract Unit closestUnit(ref Unit[] map);
        public abstract void Death();
        public abstract void string ToString();

        


    }
}
