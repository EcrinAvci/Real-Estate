using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.QuestDtos;

namespace Villa.Web.ViewComponents.Default_Index
{
    public class _DefaultQuestion: ViewComponent
    {
        private readonly IQuestService _questService;

        public _DefaultQuestion(IQuestService questService, IMapper mapper)
        {
            _questService = questService;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _questService.TGetListAsync();
            var questionList= _mapper.Map<List<ResultQuestDto>>(values);
            return View(questionList);
        }
    }
}
