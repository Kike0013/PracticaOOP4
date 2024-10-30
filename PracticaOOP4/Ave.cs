using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP4
{
    // Práctica ISP
    /* Para segregar esta interface, separamos los métodos que son comunes en todas las aves,
     * de aquellos que puede ser particulares de una o de otra
     */
    interface IAve
    {
        void Volar();
        void Cantar();
        void PonerHuevos();
        void Nadar();
        void Cazar();
    }

    // Interface con las habilidades comunes de las aves

    interface IAveComun
    {
        void Volar();
        void Cantar();
        void PonerHuevos();
    }

    // Interface para aves nadadoras, que extiende de la interface de las habilidades comunes

    interface IAveNadadora : IAveComun
    {
        void Nadar();
    }

    // Interface para aves cazadoras, que extiende de la interface de las habilidades comunes

    interface IAveCazadora : IAveComun
    {
        void Cazar();
    }

}
