using System;
using System.Reflection;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Zork_Common;
using System.IO;
using Zork.Builder.ViewModels;

namespace Zork.Builder
{
    public partial class Main : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private bool IsWorldLoaded 
        { 
            get => isWorldLoaded;
            set
            {
                isWorldLoaded = value;
                tabControl1.Enabled = isWorldLoaded;
            }
        }
        public Main()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                IsWorldLoaded = true;
            }
        }
        private WorldViewModel mViewModel;
        private bool isWorldLoaded;

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void RoomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteRoomsButton.Enabled = RoomsListBox.SelectedItem != null;
        }

        private void DeleteRoomsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)RoomsListBox.SelectedItem);
                RoomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.FileName = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewModel.SaveWorld();
        }

    }
}
