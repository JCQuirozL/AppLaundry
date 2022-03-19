using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Enums
{
    public  enum Estatus
    {
        Recibida,
        [Description("En proceso")]
        EnProceso,
        Lista,
        Entregada
    }
}
