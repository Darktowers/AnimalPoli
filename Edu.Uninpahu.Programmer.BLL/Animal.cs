using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Uninpahu.Programmer.BLL
{
    public class Animal
    {
        public double EdadPromedio { get; set; }
        public string NombreCientifico { get; set; }

        public virtual string comer()
        {
            
            return this.NombreCientifico + " Come como un Animal";
          
        }
        public string comer(bool masticar)
        {
            if (masticar)
            {
                return string.Format("{0} mastica para comer ", this.NombreCientifico);
            }
            else
            {
                return string.Format("{0} no mastica pero come ", this.NombreCientifico);
            }
            

        }
        public string comer(Animal animal)
        {
            return string.Format("{0} se come a {1} ", this.NombreCientifico, animal.NombreCientifico);
        }

        
    }
}
