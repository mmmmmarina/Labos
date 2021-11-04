using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadzba;

namespace Vsite.CSharp.KvadratnaJednadzba.Gui
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        public readonly QuadraticEquation quadraticEquation = new QuadraticEquation();

        public  void FillResults()
        {
            quadraticEquation.A = (double)this.numericUpDownA.Value;
            quadraticEquation.B = (double)this.numericUpDownB.Value;
            quadraticEquation.C = (double)this.numericUpDownC.Value;


            textBoxDiscriminant.Text = quadraticEquation.Discriminant.ToString();
            textBoxRoot1.Text = quadraticEquation.Roots[0].ToString();
            textBoxRoot2.Text = quadraticEquation.Roots[1].ToString();



        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
}
