using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED1I4_20230918
{
    internal class Senhas
    {
        private int _proximoAtendimento;
        private readonly Queue<Senha> _filaSenhas;

        public int ProximoAtendimento { get { return _proximoAtendimento; } }
        public Queue<Senha> FilaSenhas { get { return _filaSenhas; } }

        public Senhas() 
        { 
            _proximoAtendimento = 1; 
            _filaSenhas = new Queue<Senha>();
        }

        public void Gerar()
        {
            Senha senha = new(_proximoAtendimento++);
            _filaSenhas.Enqueue(senha);
        }
    }
}
