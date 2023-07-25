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
        Player _player = new Player();
        public SuperAdventure()
        {
            InitializeComponent();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {
            _player.CurrentHitPoints = 10;
            _player.MaximumHitPoints = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;

            lblHitPointsValue.Text = _player.CurrentHitPoints.ToString();
            lblGoldValue.Text = _player.Gold.ToString();
            lblExperienceValue.Text = _player.ExperiencePoints.ToString();
            lblLevelValue.Text = _player.Level.ToString();

            Location _location = new Location();
            _location.Id = 1;
            _location.Name = "Home";
            _location.Description = "This is your house .";
        }
    }
}
