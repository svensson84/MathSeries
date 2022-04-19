using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KernelLib;
using System.Diagnostics;

namespace MathSeries
{
    public partial class PowerSeriesForm : Form
    {
        public PowerSeriesForm() 
        {
            InitializeComponent();
        }

        private void btnPiAsync_Click(object sender, EventArgs e)
        {
            Kernel.executeAsync<long, double>(Series.pi, 1000000000, onPiComputed);
            updateUI(false, "compute pi - async", btnPiAsync);
        }

        [UIThreadAccessible]
        private void onPiComputed(double result)
        {
            updateUI(true, result.ToString("G17"), btnPiAsync);
        }

        private void btnFibSync_Click(object sender, EventArgs e)
        {
            Kernel.executeAsync<long, long>(Series.fibonacci, 45, onFibComputed);
            updateUI(false, "compute fib - sync", btnFibSync);
        }

        [UIThreadAccessible]
        private void onFibComputed(long result)
        {
            updateUI(true, result.ToString(), btnFibSync);
        }

        internal void btnEulersNumber_Click(object sender, EventArgs e)
        {
            Kernel.executeAsync<long, double>(Series.eulersNumber, 65, onEulersNumberComputed);
            updateUI(false, "compute eulers number - sync", btnEulersNumber);
        }

        [UIThreadAccessible]
        private void onEulersNumberComputed(double result)
        {
            updateUI(true, result.ToString("G17"), btnEulersNumber);
        }

        private void updateUI(bool enablingUI, string infoText, Button button)
        {
            button.Enabled = enablingUI;
            lblResult.Text = infoText;
        }

        private void btnAutoResetEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
