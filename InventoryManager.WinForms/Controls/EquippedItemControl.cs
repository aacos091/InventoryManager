using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Data;
using System.Windows.Forms;

namespace InventoryManager.WinForms.Controls
{
    public partial class EquippedItemControl : UserControl
    {
        public Player Player
        {
            get => mPlayer;
            set
            {
                if (mPlayer != value) 
                {
                    mPlayer = value;
                    if (mPlayer != null) 
                    { 
                        
                    }
                }
            }
        }

        public EquipLocations EquipLocation
        {
            get => mEquipLocation;
            set
            {
                mEquipLocation = value;
                equipLocationTextBox.Text = mEquipLocation.ToString();
            }
        }

        public EquippedItemControl()
        {
            InitializeComponent();
        }

        private Player mPlayer;
        private EquipLocations mEquipLocation;
    }
}
