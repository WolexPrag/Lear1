using Learn1.Other.MVP.Standart;
namespace Learn1.Other.MVP
{
    public class Presenter2d : Presenter
    {
        public Presenter2d(Model model, View view) : base(model, view)
        {

        }
        public override string GetName()
        {
            return "Presenter2d";
        }
    }
}
