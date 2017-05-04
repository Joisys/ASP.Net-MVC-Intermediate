using System.Collections.Generic;
using Jo2me.Model;

namespace Jo2me.Interface.Service
{
    public interface IStageService
    {
        Stage AddStage(Stage stage);
        IEnumerable<Stage> GetAllStages();

        Stage GetStageById(int id);

        Stage UpdateStage(Stage stage);

        void DeleteStage(int id);

    }
}