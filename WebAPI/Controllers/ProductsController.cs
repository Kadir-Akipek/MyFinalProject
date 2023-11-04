using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Extensions;
using Entities.Concrete;
using log4net.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute, class ile ilgili bilgi verme, imzalama yöntemi
    public class ProductsController : ControllerBase //Controller Base'ten inherit edildi
    {
        //Resolve(çözümlemek), bağlı olduğumuz bir class'ı new'lemek demek
        private IProductService _productService; //field'ların default'u private'dir

        //(IProductService productService) => Constructor'da bana bir manager ver diyor çünkü IProductServis ProductManager'ın referansını tutabiliyor
        //IoC Container - Inversion of Control => bir listenin içerisine(temsili) ProductManager, EfProductDal gibi refranslar koyarız ve ihtiyacı olanlar yararlanır
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] //HttpGet'imize isim verdik, bir nevi id tanımladık
        //Get request'lerde data isteriz
        public IActionResult GetList() //Get request'lerde 200 OK ile çalışırız
        {
            //Dependency chain
            //IDataResult işlem sonucunda varsa bir  mesajı, varsa bir data'yı verir
            //IProductService productService = new ProductManager(new EfProductDal()); //IProduct servis ProductManager'ın referansını tutuyor
            var result = _productService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getlistbycategory")]
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _productService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId) //id IproductService'ten geliyor
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        //Post request'lerde data gönderebiliriz, silme ve update işlemleri de yababiliriz //Product'ın karşılığı olan bir bilgiyi yollayacağız
        public IActionResult Add(Product product) //Controller'ın bildiği yer burası o yüzden istediğimiz nesneyi parametre olarak yazarız
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("transaction")]
        public IActionResult TransactionTest(Product product)
        {
            var result = _productService.TransactionalOperation(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

    }
}