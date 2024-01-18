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
        public Random r = new Random();//valore rnd per quantità domande e tipologia
        public virtual int Ndomande()
        {
           int i=r.Next(1, 30);
            return i;

        }
        public virtual string Qualid()
        {
            for(int i=0; i<Ndomande(); i++)
            {

            }
        }
    }
    public class Tipo_Domande
    {
        private bool aperte=false;
        private bool multiple=false;
        private bool vf_ = false;
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
        public virtual void Tipo2(bool vf)//Tipo2= Vero o falso
        {

        }
            
    }
    
}
