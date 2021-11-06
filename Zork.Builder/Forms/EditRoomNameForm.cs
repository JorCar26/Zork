using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.Forms
{
    public partial class EditRoomNameForm : Form
    {
        public string RoomName
        {
            get => EditRoomNameTextBox.Text;
            set => EditRoomNameTextBox.Text = value;
        }
        public EditRoomNameForm()
        {
            InitializeComponent();
        }

        private void AddRoomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }

        private void EditRoomNameForm_Load(object sender, EventArgs e)
        {
            okButton.Enabled = false;
        }
    }
}
