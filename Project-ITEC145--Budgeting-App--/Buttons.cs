﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ITEC145__Budgeting_App__
{
    internal class Buttons
    {
        static public BudgetSheet budgetForm;
        static public MainMenu menuForm;

        private int _width;
        private int _height;
        private string _name;
        private Font _font;
        private string _text;
        private Size _size;
        private Point _location;

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }


        public Buttons(int width, int height, string name, Font font, int locationx, int locationy)
        {
            string fullname = "";
            List<string> nameparts = new List<string>();
            nameparts.AddRange(name.Split(' '));

            foreach (string namepart in nameparts)
            {
                fullname += namepart;
            }

            _width = width;
            _height = height;
            _name = fullname;
            _font = font;
            _location = new Point(locationx - (_width / 2), locationy);
            _text = name;
        }

        public Button MakeButton(EventHandler clickHandler)
        {
            Button button = new Button();
            button.Name = _name;
            button.Font = _font;
            button.Text = _text;
            button.Size = new Size(_width, _height);
            button.Location = _location;
            button.Click += clickHandler;

            //void button_Click(object sender, EventArgs e)
            //{
            //    Button button = sender as Button;
            //    // identify which button was clicked and perform necessary actions
            //}

            return button;
        }

        public void doNothing_Click(object sender, EventArgs e)
        {
            //For testing
        }

        public void menuClose_Click(object sender, EventArgs e)
        {
            Buttons.menuForm.Close();
        }

        
    }
}