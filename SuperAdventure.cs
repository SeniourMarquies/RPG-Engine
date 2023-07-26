using RPG_Engine.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Engine
{
    public partial class SuperAdventure : Form
    {
        Player _player = new Player(10, 10, 20, 0, 1);
        public SuperAdventure()
        {
            InitializeComponent();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            

            lblHitPointsValue.Text = _player.CurrentHitPoints.ToString();
            lblGoldValue.Text = _player.Gold.ToString();
            lblExperienceValue.Text = _player.ExperiencePoints.ToString();
            lblLevelValue.Text = _player.Level.ToString();

            Location _location = new Location(1, "Home", "This is your house.");
           
        }
    }
}
