using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTest_Cahino
{
    public partial class Component4 : Component
    {
        public Component4()
        {
            InitializeComponent();
        }

        public Component4(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
