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


                    foreach (Ingridient ing in Ingridients)
                    {
                        

                        if (ing.Code == ingridient.Code)
                        {
                            
                            ing.Size = ing.Size + ingridient.Size;
                        }

                        else
                        {
                            Ingridients.Add(ingridient);
                        }
                        
                    }

                    // //potrzebuje zapisac gdzie jest obiekt dodany


                    // if(ingridient.Code != Ingridients[]) //Nie wiem jak zapisać NIE ZNAJDUJE SIE NA LISCIE            //jeśli składnika nie ma na liscie dodaj składnik innego typu do listy
                    //     //jeśli składnik o tej nazwie nie jest zawarty w tej tablicy Ingridients            NIEWIEM JAK TO ZAPISAC
                    // {
                    //     Ingridients.Add(ingridient); //dodaj kolejny przedmiot
                    // }
                    // else          //jeśli składnik jest na liście dodaj do istniejącego size //przeciwieństwo że jest na liscie
                    // {
                    //     ingridient.Size + obecny juz na liscie ten sam typ = pokaz sume typu
                    // }



                    //1. dodaj przedmmiot do listy

                    //2. if (dodany przedmiot ma taki code jak istniejacy już na liscie)
                    // {
                    //     To z sumuj ich wartosc i wyswiet w istniejacym juz na liscie
                    // }
                    //3. else
                    // {
                    //     dodaj do listy przedmiot
                    // }


                    //Ingridient ingridientInList;




                    //ingridientInList = Ingridients[];


                    //if (ingridient.Code == ingridientInList.Code)
                    //{
                    //    ingridientInList.Size = ingridient.Size + ingridientInList.Size;

                    //}
                    //else
                    //{
                    //    Ingridients.Add(ingridient);
                    //}
                }
            }
        }
        public decimal CurrentCapacity //włąsciwość która na poczatku ma wartośc 0 i dla kazdego ingrideient z listy Ingridients wykona działanie by do 0 dodać size który jest zadeklarowany i zwróć ta sume.
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
        public ObservableCollection<Ingridient> Ingridients { get; set; } = new ObservableCollection<Ingridient>();//pojemniczek na nasze produkty//*****//powiadamia o tym ze element został dodany do Ingridients poprzez INotifyPropertChange
    }
    class Juice
    {

    }
    class ZelmerJuiceMachine : JuiceMashine //przypisane na sztywno własciwosci
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



















//Ingridient ingridientInList;

//ingridientInList = Ingridients[];

//if (ingridient.Code == ingridientInList.Code)//sprawdzenie czy taki code jest na liscie z dodawnym
//{
//    ingridientInList.Size = ingridient.Size + ingridientInList.Size;
//}
//else
//{


//}

//ingridientInList -  na liscie
//ingridient - dodawany



//foreach (var ing in Ingridients)// przechodzi nam po każdym elemencie
//{

//    if (ingridient.Code == ing.Code)

//    {

//    }
//    //ingridient.Size = ingridient.Size + ing.Size;
//    //Ingridients.Add(ingridient);
//}