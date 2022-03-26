using AirlineProject.Application.ViewModels.CampaingViewModels;
using AirlineProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.Interfaces.ServiceInterfaces
{
    public interface ICampaingService
    {
        Task<IEnumerable<CampaingQueryViewModel>> GetAll();
        Task<CampaingQueryViewModel> GetById(int id);

        bool Create(CampaingCommandViewModel model);
        bool Update(CampaingCommandViewModel model,int id);
        bool Delete(int id);

    }
}
