using Anthera_API.DELETE_Data;
using Anthera_API.DELETE_Models;
using System.Collections.Generic;
using System.Linq;

namespace Anthera_API.Service
{
    public class DatabaseConstantService
    {
        private readonly DataContext _dataContext;
        public DatabaseConstantService(DataContext dataContext)
        {
            _dataContext = dataContext;

        }


        public List<Gender> GetAllGenders()
        {
            return _dataContext.Gender.ToList();
        }

        public List<JobTitle> GetAllJobTitles()
        {
            return _dataContext.JobTitle.ToList();
        }


    }
}
