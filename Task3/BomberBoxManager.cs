using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task3
{
    class BomberBoxManager : BoxManager
    {

        public BomberBoxManager()
        {
            this.number = 4;
            this.names = new string[] { "ArmorType", "Mass", "EnergoShield", "Single bomb power" };
            this.inputList = new List<TextBox>();
            this.captionList = new List<Label>();
        }
        public override Ship ReadBoxes(int id, frmMain frmMain)
        {
            string name = inputList[0].Text;
            int mass = Int32.Parse(inputList[1].Text);
            int shield = Int32.Parse(inputList[1].Text);
            int bomb = Int32.Parse(inputList[2].Text);

            return new Bomber(id, name, mass, shield, bomb);
        }
      


    }

}
