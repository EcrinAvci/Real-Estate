using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.DealDtos;

namespace Villa.Web.ViewComponents.Default_Index
{
    public class _DefaultDeal : ViewComponent
    {
        private readonly IDealService _dealService;

        public _DefaultDeal(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dealService.TGetListAsync();
            var dealList = _mapper.Map<List<ResultDealDto>>(values);
            return View(dealList);
        }
    }
}
