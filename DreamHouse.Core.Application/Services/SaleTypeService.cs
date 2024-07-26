﻿using AutoMapper;
using DreamHouse.Core.Application.Interfaces.Repositories;
using DreamHouse.Core.Application.Interfaces.Services;
using DreamHouse.Core.Application.Services.Commons;
using DreamHouse.Core.Application.ViewModels.SaleType;
using DreamHouse.Core.Domain.Entities;

namespace DreamHouse.Core.Application.Services
{
    public class SaleTypeService : GenericService<SaleTypeSaveViewModel, SaleTypeViewModel, SaleTypeEntity>, ISaleTypeService
    {
        private readonly ISaleTypeRepository saleTypeRepository;
        private readonly IMapper mapper;

        public SaleTypeService(
            ISaleTypeRepository saleTypeRepository,
            IMapper mapper
        )
        : base(saleTypeRepository, mapper)
        {
            this.saleTypeRepository = saleTypeRepository;
            this.mapper = mapper;
        }
    }
}
