using Anthera_API.DataContext_NEW;
using Anthera_API.Models_NEW;
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
