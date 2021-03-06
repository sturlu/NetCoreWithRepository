﻿using NetCoreWithRepository.Data.Entities;
using NetCoreWithRepository.Data.Model.Request;
using NetCoreWithRepository.Data.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NetCoreWithRepository.Service
{
    public interface ICategoryService
    {
        Task<BaseResponseModel<List<Category>>> List(Expression<Func<Category, bool>> filter, int take);
        Task<BaseResponseModel<Category>> Get(Expression<Func<Category, bool>> filter);
        Task<BaseResponseModel<Category>> Get(object Id);
        Task<BaseResponseModel<bool>> Create(CategoryRequestModel model);
        Task<BaseResponseModel<bool>> Update(CategoryRequestModel model);
        Task<BaseResponseModel<bool>> Delete(int Id);
    }
}
