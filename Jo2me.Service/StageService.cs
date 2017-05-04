using System.Collections.Generic;
using Jo2me.Interface.Infrastructure;
using Jo2me.Interface.Repository;
using Jo2me.Interface.Service;
using Jo2me.Model;

namespace Jo2me.Service
{
    public class StageService : IStageService
    {
        private readonly IStageRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public StageService(IStageRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Stage> GetAllStages()
        {
            return _repository.GetAll();
        }

        public Stage GetStageById(int id)
        {
            return _repository.GetById(id);
        }

        public Stage AddStage(Stage stage)
        {
            _repository.Add(stage);
            _unitOfWork.SaveChanges();
            return stage;
        }

        public Stage UpdateStage(Stage stage)
        {
            _repository.Update(stage);
            SaveChanges();
            return stage;
        }

        public void DeleteStage(int id)
        {
            var stage = _repository.GetById(id);
            _repository.Delete(stage);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
