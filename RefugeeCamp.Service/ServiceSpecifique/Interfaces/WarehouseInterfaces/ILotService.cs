using RefugeeCamp.Domaine.Entity;
using RefugeeCamp.Service.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefugeeCamp.Service.ServiceSpecifique.Interfaces
{
    public interface ILotService : IService<Lot>
    {
        //Retourner les lot de date expiration dépassée
         List<Lot> getLotExpiredDate();
        

        //Changer de couleur selon la qtt


        //Recherche des lots selon leur type

    }
}
