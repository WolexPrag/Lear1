
namespace Learn1.Other.MVP.Standart
{
    public abstract class Presenter
    {
        public Model _model;
        public View _view; 
        public Presenter(Model model,View view)
        {
            _model = model;
            _view = view;
        }
        public abstract string GetName();
    }
}
