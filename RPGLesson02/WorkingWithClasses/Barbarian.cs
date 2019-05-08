using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithClasses
{
    class Barbarian : livingThing_Ver5
    {
        public override int getArmour()
        {
            return 20 - Dexterity / 2;
        }

        public void renameType(string newType)
        {
            type = newType;
        }

        //public override double setDmg(int str, int con)
        //{
        //    con = Constitution;
        //    str = Strength;
        //    return (0.5 * con) + (2 * str);
        //}

        public override double setDmg()
        {
            return base.setDmg();
        }


    }

}
