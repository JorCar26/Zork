using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.Controls
{
    public partial class NeighborControl : UserControl
    {
        private Commands neighborDirection;

        public Commands NeighborDirection 
        { 
            get => neighborDirection;
            set
            {
                neighborDirection = value;
                neighborDirectionTextBox.Text = neighborDirection.ToString();
            }
        }
        public NeighborControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
