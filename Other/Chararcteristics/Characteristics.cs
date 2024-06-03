using System;
using System.Collections.Generic;

namespace Learn1.Other.Chararcteristics
{

    public class Characteristics : IValueObservable
    {
        protected List<ICharacteristic> _characteristics;
        public List<ICharacteristic> characteristics { 
            get { return _characteristics; }
            set {  
                _characteristics = value;
                _onChange?.Invoke(this); 
            } 
        }
        object IReadOnlyValue.value => characteristics;

        public Characteristics()
        {
            characteristics = new List<ICharacteristic>();
            
        }
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
