using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM
{
    public abstract class JuiceMashine
    {
        Juice MakeJuice()
        {
            return new Juice();
        }
        

        public void AddIngridient(Ingridient ingridient)
            
        {
            if (ingridient != null)
            {
                if(CurrentCapacity + ingridient.Size <= MaxCapacity)
                {
                    Ingridients.Add(ingridient);
                }
            }

        }

        public decimal CurrentCapacity
        {
            get
            {
                decimal suma = 0;
                foreach (var ingridient in Ingridients)
                {
                    suma += ingridient.Size;
                }
                return suma;
            }
        }

        public abstract decimal MaxCapacity { get;  }
        public abstract string NameJuiceMachine { get;  }
        public ObservableCollection<Ingridient> Ingridients { get; set; } = new ObservableCollection<Ingridient>();
     
    }

    class Juice
    {

    }
  

    class ZelmerJuiceMachine : JuiceMashine
    {
        public override decimal MaxCapacity
        {
            get
            {
                return 3;
            }
        }

        public override string NameJuiceMachine => "Zelmer";
    }

    class PhilipsJuiceMachine : JuiceMashine
    {
        public override decimal MaxCapacity => 2;

        public override string NameJuiceMachine => "Philips";
    }

}
