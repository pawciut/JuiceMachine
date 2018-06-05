using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
                if (CurrentCapacity + ingridient.Size  <= MaxCapacity)
                {
                    bool isEmpty = Ingridients.Count == 0;

                    bool isExi = Ingridients.Any(exi => exi.Code == ingridient.Code);

                    if (isEmpty)                                                                //JESLI LISTA JEST PUSTA 
                    {
                        //Ingridients.Add(ingridient);

                        if(ingridient.Code == "Banan")
                        {
                            Banana banan2 = new Banana();
                            banan2.Size = ingridient.Size;
                            Ingridients.Add(banan2);
                        }
                        if(ingridient.Code == "Mleko")
                        {
                            Milk milk2 = new Milk();
                            milk2.Size = ingridient.Size;
                            Ingridients.Add(milk2);
                        }
                        if(ingridient.Code =="Truskawka")
                        {
                            Strawberry truskawka2 = new Strawberry();
                            truskawka2.Size = ingridient.Size;
                            Ingridients.Add(truskawka2);
                        }
                        //STWORZYC KOPIE
                        //1.chce rozpoznać code
                        //2.stworzyć nowy obiekt
                        //3.przepisac wartosci
                    }

                    else if (isExi)                                                             //JESLI COS JEST NA LISCIE
                    {
                        foreach (Ingridient ing in Ingridients)
                        {
                            if (ing.Code == ingridient.Code)
                            {
                                ing.Size = ing.Size + ingridient.Size;
                            }
                        }
                    }
                    else                                                                        //JESLI NA LISCIE JEST PRODUKT ALE INNEGO TYPU NIZ DODAWANY
                    {
                        if (ingridient.Code == "Banan")
                        {
                            Banana banan2 = new Banana();
                            banan2.Size = ingridient.Size;
                            Ingridients.Add(banan2);
                        }
                        if (ingridient.Code == "Mleko")
                        {
                            Milk milk2 = new Milk();
                            milk2.Size = ingridient.Size;
                            Ingridients.Add(milk2);
                        }
                        if (ingridient.Code == "Truskawka")
                        {
                            Strawberry truskawka2 = new Strawberry();
                            truskawka2.Size = ingridient.Size;
                            Ingridients.Add(truskawka2);
                        }
                    }
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
        public abstract decimal MaxCapacity { get; }
        public abstract string NameJuiceMachine { get; }
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























//public abstract class Base : INotifyPropertyChanged
//{
//    public event PropertyChangedEventHandler PropertyChanged;

//    public decimal TotalSize
//    {
//        get { return this.ing.Size + this.ingridient.Size; }
//    }

//    private void OnPropertyChanged(decimal sizeA)
//    {
//        if (PropertyChanged != null)
//        {
//            PropertyChanged(this, new PropertyChangedEventArgs(sizeA));
//        }
//    }
//    private decimal sizeX;

//    public decimal SizeX
//    {
//        get { return sizeA; }
//        set
//        {
//            sizeA = value;
//            OnPropertyChanged("SizeX");
//        }
//    }
//}

//public class Rozmiar : INotifyPropertyChanged
//{

//    private decimal sizeA;
//    private decimal sizeB;
//    private decimal sizeC;
//    public decimal SizeA
//    {
//        get { return sizeA; }
//        set
//        {
//            if (sizeA != value) ;

//            sizeA = value;
//            OnPropertyChanged("SizeA");
//            OnPropertyChanged("SizeC");
//        }
//    }

//    public decimal SizeB
//    {
//        get { return sizeB; }
//        set
//        {
//            if (sizeB != value) ;
//            sizeB = value;
//            OnPropertyChanged("SizeB");
//            OnPropertyChanged("SizeC");
//        }
//    }

//    public decimal SizeC
//    {
//        get { return sizeA + SizeB; }
//        set
//        {
//            if (sizeC != value) ;
//            sizeC = value;
//            OnPropertyChanged("SizeC");
//        }
//    }

//    public event PropertyChangedEventHandler PropertyChanged;


//}
//private void OnPropertyChanged(decimal rozmiar)
//{
//    if (PropertyChanged != null)
//    {
//        PropertyChanged(this, new PropertyChangedEventArgs(rozmiar));
//    }
//}
//public Rozmiar()
//{
//    if (DesignMode.DesignModeEnable)
//    {
//        this.SizeA = ing.Size;
//        this.SizeB = ingridient.Size;
//    }

//}








//private BackgroundWorker _bgWorker = new BackgroundWorker();
//private int _workerState;



//public int WorkerState
//{
//    get { return _workerState; }
//    set
//    {
//        _workerState = value;
//        if (PropertyChanged != null)
//            PropertyChanged(this, new PropertyChangedEventArgs("WorkerState"));
//    }
//}
//public void Progress()
//{
//    _bgWorker.DoWork += (s, e) =>
//     {
//         for (int i = 0; i <= 100; i++)
//         {
//             System.Threading.Thread.Sleep(100);
//             WorkerState = i;
//         }
//     };
//    _bgWorker.RunWorkerAsync();
//}









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

//przed pętla musze mieć cos na tablicy bo przy urzyciu breakpointow mnie  wyrzuca odrazu
//foreach (Ingridient ing in Ingridients)
//{


//    if (ing.Code != ingridient.Code)    //jeśli "code" nie wystepuje na liscie dodaj
//    {

//       /* Ingridients.Add(ingridient);*/        //tu dodaje element na liste
//    }

//    if (ing.Code == ingridient.Code)    // jeśli "code" jest na liscie 
//    {
//        ing.Size = ing.Size + ingridient.Size;      //tu nie dodaje elementu tylko sumuje wartość

//    }





//}

//if (Ingridients.Contains("Banan", "Mleko", "Truskawka"))
//{
//    ing.Size = ing.Size + ingridient.Size;
//}











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