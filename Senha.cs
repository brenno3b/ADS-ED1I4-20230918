using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED1I4_20230918
{
    internal class Senha
    {
        private readonly int _id;
        private readonly DateTime _dataGerac;
        private readonly DateTime _horaGerac;
        private DateTime? _dataAtend;
        private DateTime? _horaAtend;

        public int Id { get { return _id; } }
        public DateTime DataGerac { get { return _dataGerac; } }
        public DateTime HoraGerac { get { return _horaGerac; } }
        public DateTime? DataAtend { get { return _dataAtend; } }
        public DateTime? HoraAtend { get { return _horaAtend; } }

        public Senha(int id)
        {
            _id = id;
            _dataGerac = DateTime.Now;
            _horaGerac = DateTime.Now;
        }

        public void SetAtend()
        {
            if (_dataAtend != null || _horaAtend != null) return;

            _dataAtend = DateTime.Now;
            _horaAtend = DateTime.Now;
        }

        public String DadosParciais()
        {
            return $"{_id}-{_dataGerac}";
        }

        public String DadosCompletos()
        {
            return $"{_id}-{_dataGerac}-{_dataAtend}";
        }
    }
}
