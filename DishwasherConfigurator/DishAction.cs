using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishwasherConfigurator
{
    internal class DishAction
    {
        private int type;
        private int time;

        public DishAction(int type, int time)
        {
            this.type = type;
            this.time = time;
        }

        public int getType()
        {
            return type;
        }

        public int getTime()
        {
            return time;
        }

        public void setType(int type)
        {
            this.type = type;
        }

        public void setTime(int time)
        {
            this.time = time;
        }
    }
}
