using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class frmMain : Form
    {
        BoxManager currentCaster;
        int currentId=0;
        List<Ship> list = new List<Ship>();
       
        public frmMain()
        {
            InitializeComponent();

            

           
          //  list.Add(new Ship(1, "a", 11));

           // list.Add(new ScoutShip(2, "b", 22, 222));


           
           

          
            //dataGridView1.DataSource = list;

            


        }

        private void ScoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            currentCaster = new ScoutBoxManager();
            currentCaster.AddBoxes(this);
        
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             //   currentCaster.ClearBoxes(this);
            }
            catch
            {

            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(currentCaster.ReadBoxes(++currentId, this));
            }
        
              catch
            {
                MessageBox.Show("Invalid input");

            }
        }

       
      

      
    }
}
