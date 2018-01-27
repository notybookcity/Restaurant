using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurante.DataAccess.Interfaces;
using Restaurante.DataAccess.Model;

namespace Restaurant.Domain.Cargoes
{
    public class CargoesService : ICargoesService
    {
        #region Properties

        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region  Constructor

        public CargoesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion



        public Cargo GetCargoes(int id)
        {
            return _unitOfWork.Repository<Cargo>().Get(s => s.Id == id).FirstOrDefault();
        }

        public IEnumerable<Cargo> GetAllCargoes()
        {
            return _unitOfWork.Repository<Cargo>().Get().ToList();
        }

        public void CreateOrUpdate(Cargo cargo)
        {
            _unitOfWork.Repository<Cargo>().AddOrUpdate(cargo);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Cargo cargo)
        {
            _unitOfWork.Repository<Cargo>().Remove(cargo);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Cargo> GetAllWithIncludes()
        {
            throw new NotImplementedException();
        }
    }
}
