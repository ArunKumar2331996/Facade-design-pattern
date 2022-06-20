namespace Facade_design_pattern.Accessories
{
    public class Accessories: IAccessories
    {

        public string GetMirror()
        {
            return "Bought Mirror";
        }

        public string GetTyre()
        {
            return "Bought Tyre";
        }

        public string GetBreakShoes()
        {
            return "Bought Breakshoes";
        }
    }

    public interface IAccessories {
        public string GetMirror();
        public string GetTyre();
        public string GetBreakShoes();

    }
}
