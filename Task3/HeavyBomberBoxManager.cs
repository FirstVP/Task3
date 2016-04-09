using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task3
{
    class HeavyBomberBoxManager : BoxManager
    {

        public HeavyBomberBoxManager()
        {
            this.number = 5;
            this.names = new string[] { "ArmorType", "Mass", "EnergoShield", "Single bomb power", "Single big bomb" };
            this.inputList = new List<TextBox>();
            this.captionList = new List<Label>();
        }
        public override Ship ReadBoxes(int id, frmMain frmMain)
        {
            string name = inputList[0].Text;
            int mass = Int32.Parse(inputList[1].Text);
            int shield = Int32.Parse(inputList[2].Text);
            int bomb = Int32.Parse(inputList[3].Text);
            int bigbomb = Int32.Parse(inputList[4].Text);

            return new HeavyBomber(id, name, mass, shield, bomb, bigbomb);
        }
      


    }

}
