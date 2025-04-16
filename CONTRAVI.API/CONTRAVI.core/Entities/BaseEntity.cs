using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRAVI.core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = new Random().Next(1, 10000); // manter construtor apenas nos testes sem banco de dados.
        }

        public int Id { get; private set; }
    }
}
