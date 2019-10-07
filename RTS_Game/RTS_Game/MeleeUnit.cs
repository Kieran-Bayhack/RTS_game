using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Game
{
    class MeleeUnit : Unit //inherit from unit
    {
        public MeleeUnit(int x, int y, int health, int maxHealth, int speed, int atk, int atkRange, int team, String symb)
        {
            this.x = x; //for "this" melee unit class
            this.y = y;
            this.health = health;
            this.maxHealth = maxHealth;
            this.speed = speed;
            this.atk = atk;
            this.atkRange = atkRange;
            this.team = team;
            this.symb = symb;
        }
        

        public override void Move(ref Unit closestUnit) //override abstract unit class method
        {
            if (this == closestUnit) //if melee unit is the only closest unit remaining
            {
                return; //return is used to terminate method if the melee unit is the only closest unit remaining
            }

            if (closestUnit.Team != team) //react if closest unit is not team (if enemy)
            {
                //combat
                if (health < 25) //run away
                {
                    Random r = new Random(); //method to generate random number

                    switch (r.Next(0,2))
                    {
                        case 0: x += (1 * speed); break; // X (pos) + 1 x speed. Move one and use speed (x + 1 x speed)
                        case 1: x -= (1 * speed); break; // x-1 * speed
                    }

                    switch (r.Next(0,2)) //Y is the same as X
                    {
                        case 0: y += (1 * speed); break; //speed is move distance
                        case 1: y -= (1 * speed); break;
                    }

                    if (x <= 0) //checks to see if within the bounds of the map
                    {
                        x = 0;
                    }
                    else if (x >= 20)
                    {
                        x = 20;
                    }

                    if (y <= 0)
                    {
                        y = 0;
                    }
                    else if (y >= 20)
                    {
                        y = 20;
                    }
                    //checks bounds and resets character


                }

                else if (Math.Abs(x - closestUnit.X) <= speed && Math.Abs(y - closestUnit.Y) <= speed) //check if in combat
                {
                    Combat(ref closestUnit);
                }
                else //move to closest unit
                {
                    if (x > closestUnit.X)
                    {
                        x -= speed;
                    }
                    else if (x < closestUnit.X)
                    {
                        x += speed;
                    }

                    if (y > closestUnit.Y)
                    {
                        y -= speed;
                    }
                    else if (y > closestUnit.Y)
                    {
                        y += speed;
                    }
                }
            }
        }

        public override int Atk
        {
            get { return Atk; }
            set { Atk = value; }
        }

        public override int X
        {
            get { return x; }
            set { x = value; }
        }

        public override int Y
        {
            get { return y; }
            set { y = value; }
        }

        public override string Symbol
        {
            get { return symb; }
            set { symb = value; }
        }

        public override int Team
        {
            get { return team; }
            set { team = value; }
        }


        public override void Combat(ref Unit attacker)
        {
            this.health = this.health - attacker.Atk; //melee units health - the attackers attack
            if (health <= 0)
            {
                Death();
            }
        }

        public override bool inRange(ref Unit attacker)
        {
            if (DistanceTo(attacker) == atkRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int DistanceTo(Unit unit)
        {
            int dx = Math.Abs(unit.X - x);
            int dy = Math.Abs(unit.Y - y);
            double p = Convert.ToDouble((dx * dx) + (dy * dy)); //convert to double. Square the x and y values
            return Convert.ToInt32(Math.Sqrt(p)); //gets square root of p
        }

        public override Unit closestUnit(ref Unit[] map)
        {
            Unit closest = this;
            int smallestRange = 100;
            foreach (Unit u in map)
            {
                if (u.Team != team) //if not the same team
                {
                    if (smallestRange > DistanceTo(u) && u != this)
                    {
                        smallestRange = DistanceTo(u);
                        closest = u;
                    }
                }
            }
            return closest;
        }

        public override void Death()
        {
            throw new DeathException(this.ToString() + " is dead");
        }

        public override string ToString()
        {
            return symb + ": [" + x + "," + y + "] " + health + " hp" + atk;
        }

        public class DeathException : System.Exception
        {
            public DeathException() : base() { } //new instance of exception class

            public DeathException(String message) : base(message) { }

            public DeathException(String message, System.Exception inner) : base(message, inner) { }

            protected DeathException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            { } //streaming context = source and destination
        }

        


    }
}
