using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carro.Ui.Models
{
    public class CarroModel
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public List<String> Imagens { get; set; }
    }
}
