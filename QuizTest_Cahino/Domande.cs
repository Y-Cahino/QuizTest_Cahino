using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTest_Cahino
{
    public abstract class Domande
    {
        public virtual string tipo()
        {
            Random rnd = new Random(); //valore rnd per quantità domande e tipologia


        } 
    }
    public class Tipo_Domande
    {
        private bool aperte=false;
        private bool multiple=false;
        public Tipo_Domande()
        {
            
        }
        public virtual void Tipo1(bool ap_chiuso ) //Tipo1= Aperte o Chiuse, aperte = true (presenti)
        {
            if(ap_chiuso )
            {
                aperte = true;

            } 
        }
    }
    
}
