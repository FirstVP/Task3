﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    [Serializable]
     class Ship
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Mass { get; private set; }
 
        public Ship(int id, string name, int mass)
        {
            this.Id = id;
            this.Name = name;
            this.Mass = mass;
        }
    }

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
            return (this.Id.ToString() + "\r\n" + this.Name + "\r\n" + this.Mass.ToString() + "\r\n" + this.isCloaked.ToString() + "\r\n" + "-|-|-|-|-|-|-|-|" + "\r\n");
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
