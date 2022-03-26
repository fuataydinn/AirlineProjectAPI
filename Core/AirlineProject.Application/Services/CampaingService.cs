using AirlineProject.Application.Interfaces.Repositories;
using AirlineProject.Application.Interfaces.ServiceInterfaces;
using AirlineProject.Application.ViewModels.CampaingViewModels;
using AirlineProject.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.Services
{
    public class CampaingService : ICampaingService
    {
        private readonly ICampaingRepository _campaingRepository;
        private readonly IMapper _mapper;

        public CampaingService(ICampaingRepository campaingRepository,IMapper mapper)
        {
            _campaingRepository = campaingRepository;
            _mapper = mapper;
        }
        public bool Create(CampaingCommandViewModel model)
        {
          var campaing=_mapper.Map<Campaing>(model);
            _campaingRepository.Create(campaing);
            return true;
        }

        public async Task<IEnumerable<CampaingQueryViewModel>> GetAll()
        {
            var campaings = await _campaingRepository.GetAll();
            return _mapper.Map<IEnumerable<CampaingQueryViewModel>>(campaings);
        }

        public async Task<CampaingQueryViewModel> GetById(int id)
        {
            //await demesek task turunde verecekti campaing'i 
            var campaing = await _campaingRepository.GetById(id);
            return _mapper.Map<CampaingQueryViewModel>(campaing);
        }

        public bool Update(CampaingCommandViewModel model, int id)
        {
            var checkCampaing = _campaingRepository.GetById(id).Result;

            if (checkCampaing is null)
            {
                throw new InvalidOperationException("Campaing is not found");
            }

            var campaing=_mapper.Map<Campaing>(model);
            campaing.Id = id; //viewda'id yoktu o yuzden burda verdık

            _campaingRepository.Update(campaing);
            return true;

        }
        public bool Delete(int id)
        {
            var campaing = _campaingRepository.GetById(id).Result;
            if (campaing is null)
            {
                throw new InvalidOperationException("Campaing is not found");
            }

            _campaingRepository.Delete(campaing);
            return true;
        }
    }
}
