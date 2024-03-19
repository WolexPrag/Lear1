using System;
using System.Threading;
using System.Collections.Generic;
using System.Transactions;
using System.Collections;
using System.Numerics;
using System.Linq;
using System.IO;

namespace Learn1
{
    public class Data
    { 
        public Data(string type,string name,string value)
        {
            _type = type;
            _name = name;
            _value = value;
        }
        private string _type;
        private string _name;
        private string _value;
        public string type { get { return _type; } }
        public string name { get { return _name; } }
        public string value { get { return _value; } }
    }
    public class Datas
    {
        public void Init(List<Data> data, Type typeData)
        {
            _datas = data;
            _typeData = typeData;
        }
        protected Type _typeData;
        protected List<Data> _datas; 
    }
    public interface ISavedData
    {
        public Type typeClass { get { return this.GetType(); } }
        public Datas GetDataForSave();
        public void SetDataForSave(Datas data);
    }
    public class TestClass : ISavedData
    {
        public int id;
        public string name;
        public List<string> skils;

        public void SetDataForSave(Datas data)
        {
            
        }

        Datas ISavedData.GetDataForSave()
        {
            
            Datas ret = new Datas();
            
            return ret;
        }
    }
    public class ConverterClass
    {
        public static string Convert(List<Data> data)
        {
            string ret;
            ret = data.ToString();  
            return ret;
        }
    }
    internal class Program
    {

        public static void Main(string[] args)
        {
            
        }
        
    }
}
