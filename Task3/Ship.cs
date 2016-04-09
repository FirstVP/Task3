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

     [Serializable]
    class HeavyBomber : Bomber
    {
        public int bigBomb { get; private set; }

        public HeavyBomber(int id, string name, int mass, int energoShield, int averageBomb, int bigBomb)
            : base(id, name, mass, energoShield, averageBomb)
        {
            this.bigBomb = bigBomb;
        }

        public override string ToString()
        {
            return ("Type: HeavyBomber" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.energoShield.ToString() + "\r\n" + this.averageBomb.ToString() + "\r\n" + this.bigBomb.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
    }

    [Serializable]
    class CloseContactFighter : Fighter
    {
        public int cutterPower { get; private set; }

        public CloseContactFighter(int id, string name, int mass, int energoShield, int cutterPower)
            : base(id, name, mass, energoShield)
        {
            this.cutterPower = cutterPower;
        }
        public override string ToString()
        {
            return ("Type: CloseContactFighter" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.energoShield.ToString() + "\r\n" + this.cutterPower.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
    }

    [Serializable]
    class HeavyFighter : LightFighter
    {
        public int heavyGunPower { get; private set; }

        public HeavyFighter(int id, string name, int mass, int energoShield, int lightGunPower, int heavyGunPower)
            : base(id, name, mass, energoShield, lightGunPower)
        {
            this.heavyGunPower = heavyGunPower;
        }

        public override string ToString()
        {
            return ("Type: HeavyFighter" + "\r\n" + this.Id.ToString() + "\r\n" + this.ArmorType + "\r\n" + this.Mass.ToString() + "\r\n" + this.energoShield.ToString() + "\r\n" + this.lightGunPower.ToString() + "\r\n" + this.heavyGunPower.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
        }
    }

}
