using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StatlerWaldorfCorp.EcommerceInventory.Persistence;

namespace StatlerWaldorfCorp.EcommerceInventory.Controllers
{
    [Route("api/skustatus")]
    public class SKUStatusController : Controller
    {
        private ISKUStatusRepository skuStatusRepository;

        private ILogger<SKUStatusController> logger;

        public SKUStatusController(ISKUStatusRepository skuStatusRepository, ILogger<SKUStatusController> logger)
        {
            this.skuStatusRepository = skuStatusRepository;
            this.logger = logger;
        }

        [HttpGet("{sku}")]
        public IActionResult Get(int sku)
        {
            logger.LogInformation("Handling request for SKU " + sku.ToString());
            return this.Ok(this.skuStatusRepository.Get(sku));
        }

        [HttpPut("{sku}")]
        public IActionResult Put(int sku, [FromBody]SKUStatus skuStatus)
        {
            return this.Ok(this.skuStatusRepository.Add(skuStatus));
        }
    }
}