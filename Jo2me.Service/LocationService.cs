using System.Collections.Generic;
using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Interface.Service;
using Jo2me.Model;

namespace Jo2me.Service
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(ILocationRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Location> GetLocations()
        {
            return _repository.GetAll();
        }

        public Location AddLocation(Location location)
        {
            _repository.Add(location);
            SaveChanges();
            return location;
        }

        public Location GetLocationById(int id)
        {
            return _repository.GetById(id);
        }

        public Location UpdateLoaction(Location location)
        {
            _repository.Update(location);
            SaveChanges();
            return location;
        }

        public void DeleteLocation(int id)
        {
            var location = _repository.GetById(id);
            var resources = _repository.GetMany(r => r.Id == id);

            foreach (var item in resources)
            {
                _repository.Delete(item);
            }
            _repository.Delete(location);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
