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
            this.names = new string[] { "ArmorType", "Mass", "Cloak" };
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

       /* public override int FillBoxes(frmMain frmMain, Ship ship)
        {
            string[] del = { "\r\n" };
            string[] s1 = ship.ToString().Split(del, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show(s1[0]);
            return 1;
            /*inputList[0].Text = ship.ArmorType;
            inputList[1].Text = ship.Mass.ToString();
            inputList[2].Text = ship.isCloaked.ToString();
            bool isCloaked = Boolean.Parse(inputList[2].Text);

            return new ScoutShip(id, name, mass, isCloaked);
        }*/

      
    }

}
