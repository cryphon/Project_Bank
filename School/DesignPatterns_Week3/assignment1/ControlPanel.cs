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
    public partial class ControlPanel : Form, ITrainController
    {
        TrainController _controller { get; set; }
        TrainJourney _journey { get; set; }

        public ControlPanel()
        {
            InitializeComponent();
            _journey = new TrainJourney();
            _controller = new TrainController(_journey);

        }

        public void NextStation() => _controller.NextStation();

        private void btnNewStation_Click(object sender, EventArgs e)
        {
            _controller.NextStation();
        }

        private void btnNewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay newDisplay = new TrainDisplay(_journey);
        }
    }
}
