using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task3
{
    public partial class frmMain : Form
    {
        BoxManager currentCaster;
        int currentId=0;
        List<Ship> list = new List<Ship>();

        Dictionary<Type, BoxManager> currentDictionary = new Dictionary<Type, BoxManager> {
   {typeof(ScoutShip), new ScoutBoxManager()},
   {typeof(Bomber), new BomberBoxManager()},
   {typeof(LightFighter), null}
};


        public frmMain()
        {
            InitializeComponent();
        }
        private void RefreshList()
        {
            mainTB.Text = "";
            cbMain.Items.Clear();
            foreach (Ship ship in list)
            {
                mainTB.Text += ship.ToString();
                cbMain.Items.Add(ship.Id.ToString());
            }
   
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
        private int FindIndex ()
        {
            int i = 0;
            while (list[i].Id != Int32.Parse(cbMain.Text)) i++;
            return i;
        }

        private void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editRB.Checked)
            {
                try
                {
                    if (currentCaster != null)
                        currentCaster.ClearBoxes(this);
                    currentDictionary.TryGetValue((list[FindIndex()]).GetType(), out currentCaster);
                    currentCaster.AddBoxes(this);
                    currentCaster.FillBoxes(this, list[FindIndex()]);
                }
              
                catch
                {
                    MessageBox.Show("Invalid input");
                }
            }
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

        private void ScoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        if (currentCaster != null)
            currentCaster.ClearBoxes(this);
            currentCaster = new ScoutBoxManager();
            currentCaster.AddBoxes(this);

        }

        private void bomberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentCaster != null)
            currentCaster.ClearBoxes(this);
            currentCaster = new BomberBoxManager();
            currentCaster.AddBoxes(this);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {

                FileStream currentStream = new FileStream("ships.txt", FileMode.Create);

                var serializer = new MySONFormatter<Ship>();
                serializer.Serialize(currentStream, list);
            }

            catch
            {
                MessageBox.Show("Error writing to file");

            }
      


        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            try
            {

                FileStream currentStream = new FileStream("ships.txt", FileMode.OpenOrCreate);


                var serializer = new MySONFormatter<Ship>();
                list = (List<Ship>)serializer.Deserialize(currentStream);
            }

            catch
            {
                MessageBox.Show("Incorrect file");

            }


          finally
            {
                RefreshList();
            }

         
        }

        private void lightFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentCaster != null)
                currentCaster.ClearBoxes(this);
            currentCaster = new LightFighterBoxManager();
            currentCaster.AddBoxes(this);
        }

        private void adddeleteRB_CheckedChanged(object sender, EventArgs e)
        {
            RefreshButton();
        }

       private void RefreshButton ()
        {
           if (adddeleteRB.Checked)
           {
               addButton.Enabled = true;
               deleteButton.Enabled = true;
               editButton.Enabled = false;
             
           }
           else
           {
               addButton.Enabled = false;
               deleteButton.Enabled = false;
               editButton.Enabled = true;
           }

        }

       private void editButton_Click(object sender, EventArgs e)
       {

       }
      

      
    }
}
