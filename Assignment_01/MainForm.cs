using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assignment_01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public void PrintInfo(IShip ship)
        {
            Debug.WriteLine("Weight: " + ship.getWeight().ToString() + 
                " Description: " + ship.getShipDescription());
            lblWeightOutput.Text = "Your ship weighs: " + ship.getWeight().ToString() + " tons!";
            lblDescriptionOutput.Text = "Your ship description: " + ship.getShipDescription() + ".";
            
        }

        private void btnBuildShip_Click(object sender, EventArgs e)
        {
            IShip shipBase = new Ship();

            if(chkSteel.Checked)
                shipBase = new withSteel(shipBase);
            

            if (chkNano.Checked)
                shipBase = new withNano(shipBase);

            if (chkHoney.Checked)
                shipBase = new withHoneycomb(shipBase);


            PrintInfo(shipBase);
                
            
        }
    }
}
