using System.Collections.Generic;

namespace Learn1
{
    public delegate void VoidEventParam<T1>(T1 value);
    public abstract class Characteristic<T1>
    {
        public Characteristic(string name,T1 value)
        {
            this.name = name;
            this.value = value;
        } 
        protected string _name;
        public string name { get { return _name; } protected set { _name = value; InvokeOnChange(); } }
        protected T1 _value;
        public T1 value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                InvokeOnChange();
            }
        }
        protected VoidEventParam<Characteristic<T1>> _onChange;
        protected void InvokeOnChange()
        {
            _onChange?.Invoke(this);
        }
        public virtual void SubscribeOnChange(VoidEventParam<Characteristic<T1>> func)
        {
            _onChange += func;
        }
        public virtual void UnSubscribeOnChange(VoidEventParam<Characteristic<T1>> func)
        {
            _onChange -= func;
        }

    }
    public class Health : Characteristic<float>
    {
        public Health(string name, float value) : base(name, value)
        {
        }
    }
    public class Accuracy : Characteristic<float>
    {
        public Accuracy(string name, float value) : base(name, value)
        {
        }
    }
    public class Characteristics<T1> where T1 : Characteristic<object>
    {
        protected List<T1> _characteristics;
        public T1 GetCharacteristics<GetT1>() where GetT1 : Characteristic<object>
        {
            return _characteristics.Find(f => f is GetT1);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

        }

    }
}
