using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JM
{
    public abstract class Ingridient : BindableBase
    {
    }

    public class Banana : Ingridient
    {
    }

    public class Milk : Ingridient
    {
    }

    public class Strawberry : Ingridient
    {
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