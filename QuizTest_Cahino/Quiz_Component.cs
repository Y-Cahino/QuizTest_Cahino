using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTest_Cahino
{
    public partial class Quiz_Component : Component
    {
        public Quiz_Component()
        {
            InitializeComponent();
        }
        public class QuizComposite : IComponent
        {
            private Random r = new Random();
            private IComponent[] domande;
            public QuizComposite()
            {
                int nDomande = r.Next(3, 10); //n casuale domande nel test
                for (int i = 0; i < nDomande; i++)
                {
                    int tipoDomanda = r.Next(1, 4); //n casuale per determinare tipologia doomanda
                    switch (tipoDomanda)
                    {
                        case 1:
                            domande[i] = new Component1();
                            break;
                        case 2:
                            domande[i] = new Component2();
                            break;
                        case 3:
                            domande[i] = new Component3();
                            break;
                    }
                }
            }
            public int CalcolaPunteggio()
            {
                int tot = 0;
                foreach (var domanda in domande) { tot += domanda.CalcolaPunteggio(); }
                return tot;
            }
        }
}
