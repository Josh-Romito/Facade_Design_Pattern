/**************************
 * Josh Romito
 * CP_330 - Assignment 01
 * October 10, 2017
 * ***********************/
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

        /// <summary>
        /// Prints basic info of the ship.
        /// </summary>
        /// <param name="ship">Base ship object</param>
        public void PrintInfo(IShip ship)
        {
            Debug.WriteLine("Weight: " + ship.getWeight().ToString() + 
                " Description: " + ship.getShipDescription());
            lblWeightOutput.Text = "Your ship weighs: " + ship.getWeight().ToString() + " tons!";
            lblDescriptionOutput.Text = "Your ship description: " + ship.getShipDescription() + ".";
        }

        private void btnBuildShip_Click(object sender, EventArgs e)
        {
            IShip shipBase = new Ship();                    //creating base ship

            if(chkSteel.Checked)
                shipBase = new withSteel(shipBase);         //decorating with steel

            if (chkNano.Checked)
                shipBase = new withNano(shipBase);          //decorating with nano

            if (chkHoney.Checked)
                shipBase = new withHoneycomb(shipBase);     //decorating with honeycomb


            PrintInfo(shipBase);                            //Printing ship info
        }
    }
}
