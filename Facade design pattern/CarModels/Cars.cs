namespace Facade_design_pattern.CarModels
{
    public class Cars: ICars
    {
        public string BuyHondaCity()
        {
            return "Bought HondaCity";
        }

        public string BuyHondaJazz()
        {
            return "Bought HondaJazz";
        }

        public string BuyHondaCivic()
        {
            return "Bought HondaCivic";
        }
    }

    public interface ICars {
        public string BuyHondaCity();
        public string BuyHondaJazz();
        public string BuyHondaCivic();
    }
}
