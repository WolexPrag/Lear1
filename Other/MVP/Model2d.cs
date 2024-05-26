using Learn1.Other.MVP.Standart;
namespace Learn1.Other.MVP
{
    public class Model2d : Model
    {
        public Model2d(Presenter presenter) : base(presenter)
        {

        }

        public override string GetName()
        {
            return "Model2d";
        }
    }
}
