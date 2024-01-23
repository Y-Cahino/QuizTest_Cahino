using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Markup;
using System.Windows.Forms;

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
            private List<Component> Domande = new List<Component>();
            private Random r = new Random();
            private IComponent[] domande;
            public QuizComposite(string filePath)
            {
                CaricaDomande(filePath);
            }
            private void CaricaDomande(string filePath)
            {
                int nDomande = r.Next(3, 10); //n casuale domande nel test
                try
                {
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines.Skip(1))
                    {
                        var valori = line.Split(';');
                        if (valori.Length >= 2)
                        {
                            int tipoDomanda = r.Next(1, 4); //n casuale per determinare tipologia doomanda
                            switch (tipoDomanda)
                            {
                                case 1:
                                    Domande.Add(new Component1());
                                    break;
                                case 2:
                                    Domande.Add(new Component2());
                                    break;
                                case 3:
                                    Domande.Add(new Component3());
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ecc)
                {
                    MessageBox.Show(ecc.Message);
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
