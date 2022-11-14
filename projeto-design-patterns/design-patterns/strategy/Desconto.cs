using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.design_patterns.strategy
{
    public class Desconto
    {
        private Strategy strategy;

        public void setStrategy(Strategy st)
        {
            this.strategy = st;
        }

        public float descontar()
        {
            return strategy.descontar();
        }
    }
}
