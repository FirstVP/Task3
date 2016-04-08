using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
    abstract class Ship
    {
        public int Id { get; private set; }
        public string ArmorType { get; private set; }
        public int Mass { get; private set; }
 
        public Ship(int id, string name, int mass)
        {
            this.Id = id;
            this.ArmorType = name;
            this.Mass = mass;
        }
    }

    [Serializable]
    class ScoutShip: Ship
    {
        public bool isCloaked { get; private set; }

        public ScoutShip(int id, string name, int mass, bool isCloaked)
            : base(id, name, mass)
        {
            this.isCloaked = isCloaked;
        }
        public override string ToString()
        {
            return ("Type: ScoutShip" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.isCloaked.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
  
    }

    [Serializable]
    abstract class Fighter : Ship
    {
        public int energoShield { get; private set; }

        public Fighter(int id, string name, int mass, int energoShield)
            : base(id, name, mass)
        {
            this.energoShield = energoShield;
        }
    }

    [Serializable]
    class LightFighter : Fighter
    {
        public int lightGunPower { get; private set; }

        public LightFighter(int id, string name, int mass, int energoShield, int lightGunPower)
            : base(id, name, mass, energoShield)
        {
            this.lightGunPower = lightGunPower;
        }
        public override string ToString()
        {
            return ("Type: LightFighter" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.energoShield.ToString() + "\r\n" + this.lightGunPower.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
    }

    [Serializable]
   class Bomber : Fighter
    {
        public int averageBomb { get; private set; }

        public Bomber(int id, string name, int mass, int energoShield, int averageBomb)
            : base(id, name, mass, energoShield)
        {
            this.averageBomb = averageBomb;
        }

        public override string ToString()
        {
            return ("Type: Bomber" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.energoShield.ToString() + "\r\n" + this.averageBomb.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
    }


  /*  [Serializable]
   abstract class LightShip : Ship
    {
        public int LightWeaponPower { get; private set; }
        public bool IsCloacked { get; private set; }
        public LightShip(ulong id, string name, uint mass, uint armour, int lightWeaponPower)
            : base(id, name, mass)
        {
            this.LightWeaponPower = lightWeaponPower;
        }
    }

     [Serializable]
    class HelperTwo : LightShip
    {
        public int bid { get; set; }
        public HelperTwo(int id, string name, int mnd)
            : base(id, name)
        {
            this.bid = bid;
        }
    }

     [Serializable]
    class Master : HelperTwo
    {
        public bool cid { get; set; }
        public Master(int id, string name, int bid, bool cid)
            : base(id, name, bid)
        {
            this.cid = cid;
        }
    }*/
}
