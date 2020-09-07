using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using initProject.Domain.Models;
using initProject.Domain.Services;
using InitProject.Infrastructure.Instrumentation.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitProject.WebApi.Controllers
{
    /// <summary>
    /// Represents the product controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService service;
        private ILoggerService logger;

        /// <summary>
        /// Product contstructor
        /// </summary>
        /// <param name="service">Service for performing operations for <see cref="Product"/> entity.</param>
        /// <param name="logger">Logger service to record information,debug, waring, and error details.</param>
        public ProductsController(IProductService service, ILoggerService logger)
        {
            this.service = service;
            this.logger = logger;
        }

        /// <summary>
        /// Get all products.
        /// </summary>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                logger.LogInformation("ProductsController: Calling get products.");

                var products = await this.service.GetProducts();

                logger.LogInformation("ProductsController: Completed calling get products.");

                return Ok(products);
            }
            catch (Exception ex)
            {
                logger.LogInformation($"ProductsController: An error has occured while getting all products. {ex.Message}.");

                return BadRequest("An error has occured.");
            }
        }
    }
}