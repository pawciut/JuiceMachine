using System;
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
        public event PropertyChangedEventHandler PropertyChanged;                          
        private decimal _size;                                                              
        public decimal Size
        {
            get
            {
                return _size;                                                               
            }
            set
            {
                _size = value;                                                              
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        public abstract Ingridient Copy();
    }
    class Banana : Ingridient
    {
        public override decimal DefaultSize => 0.5m;
        public override string Code => "Banan";
        public override string Icon => "http://www.i2clipart.com/cliparts/a/8/7/2/clipart-bananas-icon-a872.png";
        public override Ingridient Copy()
        {
            Banana banan2 = new Banana();
            banan2.Size = Size;
            return banan2;
        }
    }
    class Milk : Ingridient
    {
        public override decimal DefaultSize => 0.8m;
        public override string Code => "Mleko";
        public override string Icon => "http://icons.iconarchive.com/icons/jommans/cafe-noon/128/milk-icon.png";
        public override Ingridient Copy()
        {
            Milk mleko2 = new Milk();
            mleko2.Size = Size;
            return mleko2;
        }
    }
    class Strawberry : Ingridient
    {
        public override decimal DefaultSize => 0.2m;
        public override string Code => "Truskawka";
        public override string Icon => "https://vignette.wikia.nocookie.net/farmville2/images/6/6d/Strawberry.png/revision/latest?cb=20121010115153";
        public override Ingridient Copy()
        {
            Strawberry truskawki2 = new Strawberry();
            truskawki2.Size = Size;
            return truskawki2;
        }
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