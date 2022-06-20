using Facade_design_pattern.Accessories;
using Facade_design_pattern.CarModels;
using Facade_design_pattern.GeneralService;

namespace Facade_design_pattern
{
    /// <summary>
    /// This facade pattern describes the about car showroom and list of operations 
    /// that are provided by this showroom. This is the structural description of the car showroom and its operation.
    /// There are different users come to car showroom, some for buying cars, 
    /// some for accessories and some for service.
    /// This class is used in any areas where we can able to access all the methods available in the solution.
    /// </summary>
    public class CarFacadeDesignService
    {
        private readonly IService _service;
        private readonly IAccessories _accessories;
        private readonly ICars _cars;
        public CarFacadeDesignService(IService service, IAccessories accessories, ICars cars)
        {
            _service = service;
            _accessories = accessories;
            _cars = cars;
        }

        public string DoWaterWash() => _service.DoWaterWash();
        public string DoServiceCheck() => _service.DoServiceCheck();
        public int NoOfServiceLeft() => _service.NoOfServiceLeft();
        public string BuyHondaCity() => _cars.BuyHondaCity();
        public string BuyHondaJazz() => _cars.BuyHondaJazz();
        public string BuyHondaCivic() => _cars.BuyHondaCivic();
        public string BuyMirror() => _accessories.GetMirror();
        public string BuyTyre() => _accessories.GetTyre();
        public string BuyBreakShoe() => _accessories.GetBreakShoes();

    }
}
