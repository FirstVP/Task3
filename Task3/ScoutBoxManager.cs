using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task3
{
    class ScoutBoxManager : BoxManager
    {
        
        public ScoutBoxManager() 
        {
            this.number = 3;
            this.names = new string[] { "Name", "Mass", "Cloak" };
            this.inputList = new List<TextBox>();
            this.captionList = new List<Label>();
        }
        public override Ship ReadBoxes (int id, frmMain frmMain)
        {
            string name = inputList[0].Text;
            int mass = Int32.Parse(inputList[1].Text);
            bool isCloaked = Boolean.Parse(inputList[2].Text);

            return new ScoutShip(id, name, mass, isCloaked);
        }

      
    }

}
