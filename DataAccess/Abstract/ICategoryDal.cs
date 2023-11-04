using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category> //IEntityRepository'de <T> generic kullandığımız için istediğimiz veri tipini kullanabildik
    {
    }
}
