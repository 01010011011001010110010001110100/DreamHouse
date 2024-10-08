﻿using DreamHouse.Core.Application.ViewModels.User;

namespace DreamHouse.Core.Application.Interfaces.Services.User
{
    public interface IUserValidationService
    {
        Task<Dictionary<string, string>> UserSaveValidation(UserSaveViewModel userSaveViewModel);
        Task<Dictionary<string, string>> PasswordValidation(UserSaveViewModel userSaveViewModel);
        Task<Dictionary<string, string>> UserUpdateValidation(UserSaveViewModel userSaveViewModel);
    }
}
