﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loose coupled //Gevşek bağlılık.
        //IoC Container -- Inversion of Control -- Değişimin kontrolü
        //Burada IProductService new'lenmiş bir productManager'a ihtiyaç duyuyor ancak direk verirsek bağımlılık artıyor. Bu sebeple new'lenmiş olan managerları startupta tanımlıyoruz.
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            //Dependency Chain // Bağımlılık zinciri
            //IProductService productservice = new ProductManager(new EFProductDal());
            //Bu şekilde kullanabilmemizin sebebi Startupun altına eklediğimiz singleton. Çünkü elimizde somut bir referans yok (ProductManager gibi) Bunun için IoC Container kullanıyoruz.
            var result = _productService.GetAll(); 
            
            if(result.Success)
            {
                //Ok sistem başarılı demek.
                return Ok(result);
                //result altında bulunan data, success,message bilgiside json'da döner.
            }
            return BadRequest(result);
        }
    }
}
