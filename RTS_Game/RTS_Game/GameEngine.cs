using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RTS_Game
{

    class GameEngine
    {
        public Map myMap = new Map();
        private Form1 form;
        private GroupBox messageGroup;

        public GameEngine(Form1 form, GroupBox messageGroup)
        {
            this.form = form;
            this.messageGroup = messageGroup;
            foreach(Unit u in myMap.units)
            {
                Button b = new Button();
                b.Location = new Point(u.X * 35, u.Y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.Symbol;

                if (u.Team == 0) //if first team colour is red
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(MeleeUnit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                this.form.Controls.Add(b);
            }


            
        }

        public void UpdateDisplay()
        {
            form.Controls.Clear();
            form.Controls.Add(messageGroup);
            foreach (Unit u in myMap.units)
            {
                Button b = new Button();
                b.Location = new Point(u.X * 35, u.Y * 35);
                b.Size = new Size(30, 30);
                b.Text = u.Symbol;

                if (u.Team == 0)
                {
                    b.BackColor = Color.Red;
                }
                else
                {
                    b.BackColor = Color.Green;
                }

                if (u.GetType() == typeof(MeleeUnit))
                {
                    b.ForeColor = Color.White;
                }
                else
                {
                    b.ForeColor = Color.Black;
                }

                b.Click += buttonClick;
                form.Controls.Add(b);

            }

        }

        public void UpdateMap()
        {
            foreach (Unit u in myMap.units)
            {
                Unit closestunit = u.closestUnit(ref myMap.units);

                try
                {
                    u.Move(ref closestunit);
                }
                catch (Exception d)
                {
                    form.displayInfo(d.Message);
                    Unit[] temp = new Unit[myMap.units.Count() - 1];
                    int j = 0;
                    for (int i = 0; i < myMap.units.Count(); i++)
                    {
                        if (u != myMap.units[i])
                        {
                            temp[j++] = myMap.units[i];
                        }
                    }
                    myMap.units = temp;
                }
            }
        }

        public void buttonClick(object sender, EventArgs args)
        {
            foreach (Unit u in myMap.units)
            {
                if (((Button)sender).Text == u.Symbol)
                {
                    form.displayInfo(u.ToString());
                    break;
                }
            }
        }

    }

    
}
