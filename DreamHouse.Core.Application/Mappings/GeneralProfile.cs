﻿using AutoMapper;
using DreamHouse.Core.Application.Dtos.Account;
using DreamHouse.Core.Application.Features.PropertyType.Commands.Create;
using DreamHouse.Core.Application.ViewModels.Agent;
using DreamHouse.Core.Application.ViewModels.Auth;
using DreamHouse.Core.Application.ViewModels.Improvement;
using DreamHouse.Core.Application.ViewModels.Property;
using DreamHouse.Core.Application.ViewModels.PropertyFavorite;
using DreamHouse.Core.Application.ViewModels.PropertyImage;
using DreamHouse.Core.Application.ViewModels.PropertyImprovement;
using DreamHouse.Core.Application.ViewModels.PropertyType;
using DreamHouse.Core.Application.ViewModels.SaleType;
using DreamHouse.Core.Application.ViewModels.User;
using DreamHouse.Core.Domain.Entities;

namespace DreamHouse.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Authentication
            CreateMap<AuthenticationRequest, LoginViewModel>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ReverseMap();
            #endregion

            #region User

            CreateMap<UserViewModel, AuthenticationResponse>()
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore())
                .ForMember(destino => destino.IsVerified, otp => otp.Ignore())
                .ReverseMap()
                .ForMember(destino => destino.Password, otp => otp.Ignore());

            CreateMap<UserSaveViewModel, RegisterRequest>()
                .ReverseMap()
                .ForMember(destino => destino.File, otp => otp.Ignore())
                .ForMember(destino => destino.HasError, otp => otp.Ignore())
                .ForMember(destino => destino.ErrorDescription, otp => otp.Ignore());

            CreateMap<UserSaveViewModel, AuthenticationResponse>()
                //.ForMember(destino => destino.PhoneNumber, otp => otp.Ignore())   FUI YO RAFAELLL
                .ReverseMap()
                .ForMember(destino => destino.File, otp => otp.Ignore())
                .ForMember(destino => destino.Password, otp => otp.Ignore())
                .ForMember(destino => destino.ConfirmPassword, otp => otp.Ignore());

            CreateMap<UserViewModel, AgentViewModel>()
                .ForMember(destino => destino.NumberPropertiesAssigned, otp => otp.Ignore())
                .ReverseMap();


            #endregion

            #region Property

            CreateMap<PropertyEntity, PropertyViewModel>()
                .ForMember(destino => destino.MarkedAsFavorite, otp => otp.Ignore())
                .ReverseMap();

            //CreateMap<SaleTypeEntity, SaleTypeViewModel>().ReverseMap();

            #endregion

            #region PropertyFavoriteViewModel

            CreateMap<PropertyFavoriteEntity, PropertyFavoriteViewModel>()
                .ReverseMap();

            #endregion

            #region PropertyImageViewModel

            CreateMap<PropertyImageEntity, PropertyImageViewModel>()
                .ReverseMap();

            #endregion

            #region PropertyImprovementViewModel

            CreateMap<PropertyImprovementEntity, PropertyImprovementViewModel>()
                .ReverseMap();

            #endregion

            #region PropertyType
            CreateMap<PropertyTypeEntity, PropertyTypeViewModel>()
                .ForMember(destino => destino.CuantityPropertiesAssigned, otp => otp.Ignore())
                .ReverseMap();

            CreateMap<PropertyTypeEntity, PropertyTypeSaveViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.Properties, otp => otp.Ignore());

            #endregion

            #region SalesType
            CreateMap<SaleTypeEntity, SaleTypeViewModel>()
                .ForMember(destino => destino.CuantitySalesAssigned, otp => otp.Ignore())
                .ReverseMap();

            CreateMap<SaleTypeEntity, SaleTypeSaveViewModel>().ReverseMap();

            #endregion

            #region Improvements
            CreateMap<ImprovementEntity, ImprovementViewModel>()
                .ReverseMap();

            CreateMap<ImprovementEntity, ImprovementSaveViewModel>()
                .ReverseMap()
                .ForMember(destino => destino.ImprovementProperties, otp => otp.Ignore());

            #endregion

            #region PropertyTypeCommand
            CreateMap<PropertyTypeEntity, CreatePropertyTypeCommand>()
                .ReverseMap()
                .ForMember(destino => destino.Id, otp => otp.Ignore());

            #endregion


        }
    }
}
