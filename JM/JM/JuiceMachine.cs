using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM
{
    public abstract class JuiceMashine : BindableBase
    {
    }

    public class ZelmerJuiceMachine : JuiceMashine
    { 
    }

    public class PhilipsJuiceMachine : JuiceMashine
    {
    }
}