using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Task3
{
    abstract class BoxManager
    {
        protected int number;
        protected string[] names;

        protected List<TextBox> inputList;
        protected List<Label> captionList;
        public void AddBoxes(frmMain frmMain)
    {
        

        for (int i = 0; i < number; i++)
            {
                int y = 10 + (i + 1) * 50;
               inputList.Add(new TextBox() { Name = i.ToString(), Location = new Point(2, y), Text = "" });
               captionList.Add(new Label() { Name = i.ToString(), Location = new Point(2, y-30), Text = names[i] });

               frmMain.Controls.Add(captionList[i]);
               frmMain.Controls.Add(inputList[i]);
            }
        
    }

        public abstract Ship ReadBoxes(int id, frmMain frmMain);

        public int FillBoxes(frmMain frmMain, Ship ship)
        {
            int result = 1;
            string[] del = { "\r\n" };
       
            string[] currentProperties = ship.ToString().Split(del, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 2; i < currentProperties.Length - 1; i++ )
            {
                inputList[i-2].Text = currentProperties[i];
            }

            result = Int32.Parse(currentProperties[1]);

            return result;
            /*inputList[0].Text = ship.ArmorType;
            inputList[1].Text = ship.Mass.ToString();
            inputList[2].Text = ship.isCloaked.ToString();
            bool isCloaked = Boolean.Parse(inputList[2].Text);

            return new ScoutShip(id, name, mass, isCloaked);*/
        
        }

        public void ClearBoxes(frmMain frmMain)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
           
                frmMain.Controls.Remove(captionList[i]);
                frmMain.Controls.Remove(inputList[i]);
            }
        }

    }
}
