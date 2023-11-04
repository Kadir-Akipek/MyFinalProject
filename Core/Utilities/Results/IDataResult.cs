using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Interface'den interface'e implementasyona gerek yoktur
    public interface IDataResult<out T>: IResult //Data'da neyi döndüreceğimizi bilmediğimiz için(ürün, ürün listesi, kategori, dto.vs) bu yüzden generic<> kullandık
    {
        //IResult'da success ve message bulunduğu için sadece Data'yı ekleyeceğiz
        T Data { get; }
    }
}
