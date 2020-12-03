using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.WinForms.Controls;
using InventoryManager.WinForms.ViewModels;

namespace InventoryManager.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                mViewModel = value;
                worldViewModelBindingSource.DataSource = mViewModel;
            }
        }

        private bool isWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                mainTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            isWorldLoaded = false;

            mEquippedItemControlMap = new Dictionary<EquipLocations, EquippedItemControl>
            {
                { EquipLocations.LeftHand, LeftHandEquippedItemControl },
                { EquipLocations.RightHand, RightHandEquippedItemControl },
                { EquipLocations.Head, HeadEquippedItemControl },
                { EquipLocations.Feet, FeetEquippedItemControl }
            };
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            using (AddPlayerForm addPlayerForm = new AddPlayerForm())
            {
                if (addPlayerForm.ShowDialog() == DialogResult.OK)
                {
                    Player player = new Player { Name = addPlayerForm.playerName };
                    ViewModel.Players.Add(player);
                }
            }
        }

        private void PlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deletePlayerButton.Enabled = playersListBox.SelectedItem != null;

            Player selectedPlayer = playersListBox.SelectedItem as Player;
            foreach (var control in mEquippedItemControlMap.Values)
            {
                control.Player = selectedPlayer;
            }
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Delete this player?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                ViewModel.Players.Remove((Player)playersListBox.SelectedItem);
                playersListBox.SelectedItem = ViewModel.Players.FirstOrDefault();
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteItemButton.Enabled = itemsListBox.SelectedItem != null;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    Item item = new Item { Name = addItemForm.itemName };
                    ViewModel.Items.Add(item);
                }
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this item?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Items.Remove((Item)itemsListBox.SelectedItem);
                itemsListBox.SelectedItem = ViewModel.Items.FirstOrDefault();
            }
        }

        #region Main Menu
        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;

                Player selectedPlayer = playersListBox.SelectedItem as Player;
                foreach (var control in mEquippedItemControlMap.Values) 
                {
                    control.Player = selectedPlayer;
                }

                isWorldLoaded = true;
            }
        }

        private void closeWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) => ViewModel.SaveWorld();

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Main Menu

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;
        private readonly Dictionary<EquipLocations, EquippedItemControl> mEquippedItemControlMap;

    }
}
