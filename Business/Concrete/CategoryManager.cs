using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İş Kodları
            return _cotegoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _cotegoryDal.Get(c => c.CategoryId == categoryId);//select * from catagories where categoryId=3 demek
        }
    }
}
