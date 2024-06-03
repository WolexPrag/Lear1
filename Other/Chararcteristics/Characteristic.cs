using System;

namespace Learn1.Other.Chararcteristics
{
    public delegate void VoidEventParam<T1>(T1 value);
    public interface IReadOnlyValue
    {
        public object value { get; }
    }
    public interface IChangeNotifier<T1>
    {
        public abstract void Subscribe(VoidEventParam<T1> subscriber);
        public abstract void UnSubscribe(VoidEventParam<T1> subscriber);
    }
    public class ChangeNotifier<T1>
    {
    }
    public interface IValueObservable : IReadOnlyValue, IChangeNotifier<IValueObservable>
    {
    }
    public interface ICharacteristic : IValueObservable
    {

    }
    public abstract class Characteristic<T1> : ICharacteristic
    {
        public Characteristic(T1 value)
        {
            this.value = value;
        }
        protected T1 _value;
        public T1 value {
            get { return _value; }
            set {
                _value = value;
                _onChange?.Invoke(this);
            }
        }
        object IReadOnlyValue.value { get { return value; } }

        protected VoidEventParam<IValueObservable> _onChange;
        public virtual void Subscribe(VoidEventParam<IValueObservable> subscriber)
        {
            _onChange += subscriber;
        }
        public virtual void UnSubscribe(VoidEventParam<IValueObservable> subscriber)
        {
            _onChange -= subscriber;
        }
    }
}
