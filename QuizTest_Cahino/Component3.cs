﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTest_Cahino
{
    public partial class Component3 : Component
    {
        public Component3()
        {
            InitializeComponent();
        }

        public Component3(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
