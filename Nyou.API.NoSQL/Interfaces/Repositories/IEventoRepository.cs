using Nyou.API.NoSQL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyou.API.NoSQL.Interfaces.Repositories
{
   public interface IEventoRepository
    {
        List<EventoDomain> Listar();

        EventoDomain BuscarPorId(string Id);

        void Adicionar(EventoDomain evento);

        void Atualizar(string id, EventoDomain evento);

        void Remover(string id);
    }
}
