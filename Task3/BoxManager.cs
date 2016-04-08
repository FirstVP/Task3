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
