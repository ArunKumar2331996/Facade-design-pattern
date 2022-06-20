namespace Facade_design_pattern.GeneralService
{
    public class Service: IService
    {
        public string DoWaterWash()
        {
            return "Waterwash done!";
        }

        public string DoServiceCheck()
        {
            return "Service done";
        }

        public int NoOfServiceLeft()
        {
            return 2;
        }
    }

    public interface IService {
        public string DoWaterWash();
        public string DoServiceCheck();
        public int NoOfServiceLeft();

    }
}
