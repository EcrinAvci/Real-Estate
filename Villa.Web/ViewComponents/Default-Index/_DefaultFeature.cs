﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.FeatureDtos;

namespace Villa.Web.ViewComponents.Default_Index
{
    public class _DefaultFeature:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _DefaultFeature(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.TGetListAsync();
            var featureList = _mapper.Map<List<ResultFeatureDto>>(values);
            return View(featureList);
        }
    }
}
