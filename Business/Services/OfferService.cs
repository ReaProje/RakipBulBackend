﻿using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class OfferService : BaseService<Offer, ShowOfferDto, int>,IOfferService
    {
        public OfferService(IMapperHelper mapperHelper, IRepository<Offer, int> repository, IUnitOfWork unitOfWork) : base(mapperHelper, repository, unitOfWork)
        {
        }
    }
}
