using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM
{
    public abstract class Ingridient
    {
        public abstract decimal DefaultSize { get; }

        public abstract string Code { get; }

        public abstract string Icon { get; }

        public decimal Size { get; set; }

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
