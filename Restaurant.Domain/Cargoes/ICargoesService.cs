using System.Collections;
using System.Collections.Generic;
using Restaurante.DataAccess.Model;

namespace Restaurant.Domain.Cargoes
{
    public interface ICargoesService
    {
        Cargo GetCargoes(int key);
        IEnumerable<Cargo> GetAllCargoes();
        void CreateOrUpdate(Cargo cargo);
        void Delete(Cargo cargo);
        IEnumerable<Cargo> GetAllWithIncludes();
    }
}
