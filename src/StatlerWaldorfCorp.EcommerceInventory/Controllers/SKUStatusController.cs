using System;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorfCorp.EcommerceInventory.Persistence;

namespace StatlerWaldorfCorp.EcommerceInventory.Controllers
{
    [Route("api/skustatus")]    
    public class SKUStatusController : Controller    
    {
        private ISKUStatusRepository skuStatusRepository;

        public SKUStatusController(ISKUStatusRepository skuStatusRepository)
        {
            this.skuStatusRepository = skuStatusRepository;
        }

        [HttpGet]
        public IActionResult Get(int sku)
        {
            return this.Ok(this.skuStatusRepository.Get(sku));
        }

        [HttpPut]
        public IActionResult Put(SKUStatus skuStatus)
        {
            return this.Ok(this.skuStatusRepository.Add(skuStatus));
        }
    }
}