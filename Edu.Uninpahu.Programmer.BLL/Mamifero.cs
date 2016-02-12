using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Uninpahu.Programmer.BLL
{
    public class Mamifero : Animal
    {
        public override string comer()
        {
            return string.Format("{0} come como un mamifero", this.NombreCientifico);
        } 
       
    }
   

}
