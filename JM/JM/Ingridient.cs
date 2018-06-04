﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JM
{
    public abstract class Ingridient : INotifyPropertyChanged
    {
        public abstract decimal DefaultSize { get; }

        public abstract string Code { get; }

        public abstract string Icon { get; }

        //public decimal Size { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;                           //implementujemy interfejs - chcemy by interfejs informował widok że coś się w nim zmieni

        private decimal _size;                                                              //deklaracja właściwego pola klasy
        public decimal Size
        {
            get
            {
                return _size;                                                               //chce by zwracało mi size z rozmiar obecny plus dodawany
            }

            set
            {
                _size = value;                                                              //value - wartość przypisywana właściwości jest równa zmiennej
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
    }
    class Banana : Ingridient
    {
        public override decimal DefaultSize => 0.5m;

        public override string Code => "Banan";

        public override string Icon => "http://www.i2clipart.com/cliparts/a/8/7/2/clipart-bananas-icon-a872.png";
    }
    class Milk : Ingridient
    {
        public override decimal DefaultSize => 0.8m;

        public override string Code => "Mleko";

        public override string Icon => "http://icons.iconarchive.com/icons/jommans/cafe-noon/128/milk-icon.png";
    }
    class Strawberry : Ingridient
    {
        public override decimal DefaultSize => 0.2m;

        public override string Code => "Truskawka";

        public override string Icon => "https://vignette.wikia.nocookie.net/farmville2/images/6/6d/Strawberry.png/revision/latest?cb=20121010115153";
    }
}

























//private decimal _size;                                                       //deklaracja właściwego pola klasy
//public decimal Size                                                         //właściwość
//{
//    get                                                                     // można pobrać wartość jeśli tam będzie
//    {
//        return _size;                                                        //zwraca pole 
//    }
//    set                                                                     //pozwala ustawić wartość tej zmniennej
//    {
//        _size = value;                                                       //przypisuje do pola (value - Przedstawia on w sposób symboliczny wartość przypisywaną właściwości)
//        OnPropertyChanged(Size);                                            //poinformuj ze włąściwość jest aktualizowana, a że właściwość jest przypisana do xamla informuje xamla zę uległa zmianie
//    }
//}


//public event PropertyChangedEventHandler PropertyChanged;                       //1.implementujemy interfejs - chcemy by interfejs informował innych że jeśli coś się w nim zmieni
//private void OnPropertyChanged(Ingridient Size)                                 //2.tworzymy metode która będzie nas o tym informowała - parametry to zmienne muszą być przesłane do metody by wykonać daną operacje.
//{
//    if (PropertyChanged != null)                                                //3.jeśli zdażenie się wydarzyło poinformuj o zmianie 
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));    //4.to do eventu,  PropertyChangedEventArgs (Dostarcza dane do PropertyChanged zdarzeń)
//    }
//    //PropertyChanged zdarzenie jest inicjowane, gdy składnik zostanie zmieniona właściwość. A PropertyChangedEventArgs obiektu określa nazwę właściwości, która się zmieniła.
//}
//    }