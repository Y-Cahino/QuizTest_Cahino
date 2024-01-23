using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTest_Cahino
{
    public partial class UserControl1: UserControl
    {
        Quiz_Component quiz = new Quiz_Component();
        public UserControl1()
        {
            InitializeComponent();
            string filePath = "domande.csv";
            
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int punteggio = quiz.CalcolaPunteggio();
        }
    }
}
