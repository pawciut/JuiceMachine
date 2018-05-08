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
  
                    if (Ingridients.Count == 0)
                    {
                        Ingridients.Add(ingridient);
                    }
                    else
                    {
                        Ingridient ingridientInList;
                        for (int i = 0; i < Ingridients.Count; i++)//tworzymy pętle która ma wykonywać czynnosć określoną ilośc razy
                        {
                            ingridientInList = Ingridients[i];//wyciagam element z listy który znajduje sie na pozycji i
                            if (ingridient.Code == ingridientInList.Code)
                            {
                                ingridientInList.Size = ingridient.Size + ingridientInList.Size;
                                /*ingridient.Size = ingridient.Size + ingridientInList.Size;*/ //wyciagnięty element z listy dodajemy do dodawanego już - jeśli jest ta sama nazwa
                                                                                               // ingriedient.Size - jest to wartość która jest zczytywana 


                            }
                            else
                            {
                                Ingridients.Add(ingridient);
                            }

                        }
                    }



                      



                    //foreach (var ing in Ingridients)// przechodzi nam po każdym elemencie
                    //{

                    //    if (ingridient.Code == ing.Code)

                    //    {

                    //    }
                    //    //ingridient.Size = ingridient.Size + ing.Size;
                    //    //Ingridients.Add(ingridient);
                    //}


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
