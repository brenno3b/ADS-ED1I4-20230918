using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED1I4_20230918
{
    internal class Guiches
    {
        private readonly List<Guiche> _listaGuiches;

        public List<Guiche> ListaGuiches { get { return _listaGuiches; } }

        public Guiches()
        {
            _listaGuiches = new List<Guiche>();
        }

        public void AdicionarGuiche(Guiche guiche)
        {
            _listaGuiches.Add(guiche);
        }
    }
}
