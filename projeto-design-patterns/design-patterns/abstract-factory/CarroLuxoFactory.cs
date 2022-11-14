using projeto_design_patterns.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_design_patterns.design_patterns
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Carro montarCarro()
        {
            return new Luxo("Porsche", "Panamera", "Preto", 917000, true, true);
        }
    }
}
