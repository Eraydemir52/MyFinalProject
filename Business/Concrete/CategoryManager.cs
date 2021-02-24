using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _cotegoryDal;

        public CategoryManager(ICategoryDal cotegoryDal)
        {
            _cotegoryDal = cotegoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş Kodları
            return new SuccessDataResult<List<Category>>( _cotegoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_cotegoryDal.Get(c => c.CategoryId == categoryId));//select * from catagories where categoryId=3 demek
        }
    }
}
