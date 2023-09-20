﻿using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class UserController : BaseCRUDController<User, int, RegisterDto, UserProfileUpdateDto, UserProfileDto>
    {
        public UserController(IBaseService<User, UserProfileDto, int> service) : base(service)
        {
        }
    }
}