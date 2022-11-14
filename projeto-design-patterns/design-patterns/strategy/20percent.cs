using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.design_patterns.strategy
{
    public class _20percent : Strategy
    {
        public override float descontar()
        {
            return (float)0.2;
        }
    }
}
