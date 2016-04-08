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
        }
        private void RefreshList()
        {
            mainTB.Text = "";
            foreach (Ship ship in list)
                mainTB.Text += ship.ToString();

            
                
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

                cbMain.Items.Add(currentId.ToString());
            }
        
              catch
            {
                MessageBox.Show("Invalid input");

            }
            finally
            {
                RefreshList();
            }
        }

        private void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                while (list[i].Id != Int32.Parse(cbMain.Text)) i++;
                list.RemoveAt(i);
                cbMain.Items.Remove(cbMain.SelectedItem);
            }

            catch
            {
                MessageBox.Show("Invalid input");

            }
            finally
            {
                RefreshList();
            }
        }

       
      

      
    }
}
