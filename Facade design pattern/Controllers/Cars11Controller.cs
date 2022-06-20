using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facade_design_pattern.Controllers
{
    /// <summary>
    /// This is the new car showroom controller which provides different services to the customers.
    /// Visit CarFacadeDesignService for more description. 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class Cars11Controller : ControllerBase
    {
        private readonly CarFacadeDesignService _carFacadeDesignService;
        public Cars11Controller(CarFacadeDesignService carFacadeDesignService)
        {
            _carFacadeDesignService = carFacadeDesignService;
        }

        [HttpGet("Jazz")]
        public string BookJazz()
        { 
            return _carFacadeDesignService.BuyHondaJazz();
        }

        [HttpGet("BookService")]
        public string BookGeneralService()
        {
            return _carFacadeDesignService.DoServiceCheck();
        }

        [HttpGet("BookTyre")]
        public string BookNewTyre()
        {
            return _carFacadeDesignService.BuyTyre();
        }
    }
}
