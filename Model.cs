using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace twozerofoureight
{
    public class Model
    {
        protected ArrayList oList;
        protected int Score;
        protected bool Gameover = false;
        protected bool toviweGameover = false;
        public bool is_full = false;

        public Model()
        {
            oList = new ArrayList();
        }
        public void NotifyAll()
        {
            foreach (View m in oList)
            {
                m.Notify(this);
            }
        }

        public void AttachObserver(View m)
        {
            oList.Add(m);
        }

        public int ScoreTotal()
        {
            return Score;
        }

        public Boolean Game_over()
        {
            if (Gameover == true && is_full == true)
            {
                toviweGameover = true;
            }
            else
            {
                toviweGameover = false;
            }
            return toviweGameover;
        }

    }
}
