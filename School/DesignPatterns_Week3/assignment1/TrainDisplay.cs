using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns_Week3
{
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        public TrainDisplay(ITrainJourney _journey)
        {
            InitializeComponent();
            _journey.AddObserver(this);
            Text = $"Train display #{_journey.GetObserverCount()}";
            Show();

        }

        public void Update(Station station)
        {
            lblStation.Text = station._name;
            lblTrack.Text = station._arrivalTrack.ToString();
        }
    }
}
