﻿using System;
using System.Collections.Generic;
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

        void AddIngridient(Ingridient ingridient)
        {

        }
        public abstract decimal MaxCapacity { get;  } 
        public abstract string NameJuiceMachine { get;  }
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