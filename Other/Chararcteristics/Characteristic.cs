using System;

namespace Learn1.Other.Chararcteristics
{
    public delegate void VoidEventParam<T1>(T1 value);
    public interface IReadOnlyValue
    {
        public object value { get; }
    }
    public interface IChangeNotifier
    {
        public void Subscribe<T1>(VoidEventParam<T1> subscriber);
        public void UnSubscribe<T1>(VoidEventParam<T1> subscriber);
    }
    public interface IValueObservable : IReadOnlyValue,IChangeNotifier
    {
        
    }
    public abstract class Characteristic<T1> : IValueObservable
    {
        
        protected T1 _value;
        public T1 value { get { return _value; } set {  _value = value; } }
        object IReadOnlyValue.value { get { return value; } }

        

        public abstract void Subscribe<IValueObservable>(VoidEventParam<IValueObservable> subscriber);
        public abstract void UnSubscribe<IValueObservable>(VoidEventParam<IValueObservable> subscriber);
    }
}
