using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_ED1I4_20230918
{
    internal class Guiche
    {
        private readonly int _id;
        private readonly Queue<Senha> _atendimentos;

        public int Id { get { return _id; } }
        public Queue<Senha> Atendimentos { get { return _atendimentos; } }

        public Guiche()
        {
            _id = 0; 
            _atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            _id = id;
            _atendimentos = new Queue<Senha>();
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count == 0) return false;

            Senha senha = filaSenhas.Dequeue();
            senha.SetAtend();
            _atendimentos.Enqueue(senha);

            return true;
        }
    }
}
