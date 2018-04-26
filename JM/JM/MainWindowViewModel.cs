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
    public class MainWindowViewModel /*: BindableBase*/
    {
        public string Title { get; set; } = "JuiceMachineApp";
        

        //public JuiceMashine CurrentJuiceMachine { get; set; } = new PhilipsJuiceMachine();

        public JuiceMashine CurrentJuiceMachine { get; set; } = new ZelmerJuiceMachine();

        //public List<Ingridient> ListProducts = new List<Ingridient>();

        public List<Ingridient> ListProducts { get; set; } = new List<Ingridient>();

        public ICommand AddCommand { get; set; }


        public MainWindowViewModel()
        {
            ListProducts.Add(new Banana());
            ListProducts.Add(new Milk());
            ListProducts.Add(new Strawberry());

            AddCommand = new DelegateCommand(AddCommandExecute);
        }

        public void AddCommandExecute()
        {

        }
    }

    
}
