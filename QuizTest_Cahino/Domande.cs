using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTest_Cahino
{
    
    public interface IComponent
    {
        int CalcolaPunteggio();
    }
    public class Component1 : IComponent
    {
        public int CalcolaPunteggio() { return 1; }
    }
    public class Component2 : IComponent
    {
        public int CalcolaPunteggio() { return 2; }
    }
    public class Component3 : IComponent
    {
        public int CalcolaPunteggio() { return 1; }
    }
    public class QuizComposite:IComponent
    {
       private Random r= new Random();
        private IComponent[] domande;
        public QuizComposite()
        {
            int nDomande=r.Next(3,10); //n casuale domande nel test
            for(int i=0;i<nDomande;i++)
            {
                int tipoDomanda=r.Next(1,4); //n casuale per determinare tipologia doomanda
            }
        }
       
            
    }
    
}
