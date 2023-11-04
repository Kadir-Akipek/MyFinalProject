using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Interface'in operasyonları public'tir, kendisi değildir
    //Eğer alternatif teknolojisi olan bir ortamı kullanıyorsanız(ADO.NET, Entity Framework vs.) hemen orada klasörleme tekniğini kullanın
    public interface IProductDal:IEntityRepository<Product> //IProductDal sen bir IEntityRepository'sin ve çalışma tipin Product //IEntityRepository'i product için yapılandırdık
    {

    }
}
