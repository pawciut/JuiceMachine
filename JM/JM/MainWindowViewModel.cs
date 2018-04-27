using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JM
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title { get; set; } = "JuiceMachineApp";
        

        //public JuiceMashine CurrentJuiceMachine { get; set; } = new PhilipsJuiceMachine();

        public JuiceMashine CurrentJuiceMachine { get; set; } = new ZelmerJuiceMachine();

        //public List<Ingridient> ListProducts = new List<Ingridient>();

        public List<Ingridient> ListProducts { get; set; } = new List<Ingridient>();

        public ICommand AddCommand { get; set; }

        

        Ingridient selectedIngridient;
        public Ingridient SelectedIngridient
        {
            get
            {
                return selectedIngridient;
            }
            set
            {
                
                selectedIngridient = value;
                selectedIngridient.Size = value.DefaultSize;
                
          
                this.RaisePropertyChanged();
            }
        }


        public MainWindowViewModel()
        {
            ListProducts.Add(new Banana());
            ListProducts.Add(new Milk());
            ListProducts.Add(new Strawberry());
            

            AddCommand = new DelegateCommand(AddCommandExecute);
        }

        public void AddCommandExecute()
        {

            if (SelectedIngridient != null)
            {

                CurrentJuiceMachine.AddIngridient(SelectedIngridient);
            }



            //chce by dodane do sokowirówki elementy nie przekraczały maxymalnej objentości tj.3l
            //if (CurrentJuiceMachine. < CurrentJuiceMachine.MaxCapacity) ; //obecna sokowirowka dodaje elementy, mają one być < od pojemnosci obecnnej sokowiróki - jest to źle zapisane i nie wiem jak to zapisac  
            //{
            //    CurrentJuiceMachine.AddIngridient(SelectedIngridient);
            //}

            //if (SelectedIngridient.DefaultSize < CurrentJuiceMachine.MaxCapacity) ;
            //{
            //    CurrentJuiceMachine.AddIngridient(SelectedIngridient);
            //}


        }

    }

    

    
}
