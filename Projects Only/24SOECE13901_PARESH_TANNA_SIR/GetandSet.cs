using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13901_PARESH_TANNA_SIR
{
    internal class GetandSet
    {
        private int id;
        public int getID()
        {
            return id;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

class PropertyDemo
{
    //obj.Id = 101;
}
