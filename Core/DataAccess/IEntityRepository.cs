using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{   //Core katmanı hiçbir katmanı referans almaz
    //<T> generic ile istediğimiz veri tipini kullanabileceğiz
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    //generic constraint ile T yerine gelebilecek veri tiplerini sınırlandıracağız
    public interface IEntityRepository<T> where T:class,IEntity,new() //generic oluşturduk ve kısıtlamalarını yazdık
    {
        //Operasyonlarımızı tanımladık
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter=null); //GetAll metoduna expression ekleyebilmemiz için bu kodu yazdık
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
