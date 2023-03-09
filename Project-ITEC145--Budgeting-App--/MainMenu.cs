﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ITEC145__Budgeting_App__
{
    public partial class MainMenu : Form
    {
        Buttons MainMenuButtons;
        Interface MainMenuInterface;

        public MainMenu()
        {
            Buttons.menuForm = this;
            Interface.menuForm = this;

            MainMenuInterface = new Interface();
            
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Buttons NewButton = new Buttons(150, 50, "New Budget", new Font("Arial", 12, FontStyle.Regular), MainMenuInterface.GetWindowCenterX(this), 50);
            Buttons LoadButton = new Buttons(150, 50, "Load Budget", new Font("Arial", 12, FontStyle.Regular), MainMenuInterface.GetWindowCenterX(this), 100);
            Buttons ExitButton = new Buttons(150, 50, "Exit", new Font("Arial", 12, FontStyle.Regular), MainMenuInterface.GetWindowCenterX(this), 350);

            Controls.Add(NewButton.MakeButton());
            Controls.Add(LoadButton.MakeButton());
            Controls.Add(ExitButton.MakeButton());
        }
    }
}
