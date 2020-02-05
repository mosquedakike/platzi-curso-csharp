using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string Nombre { get; set; }
        public string UniqueId { get; set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}
