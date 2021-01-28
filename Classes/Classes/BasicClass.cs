using System.Collections.Generic;

namespace Classes
{
    public class BasicClass
    {   //basic member variable
        public int _basicMemberVairable;

        //readonly field
        readonly List<string> ListStringVariable = new List<string>();

        //basic constructor
        public BasicClass() { }

        //basic method
        public int BasicMethod() { return 0; }

        private int _AutoMembervariable {get; set;}

        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]{
            get{return _dictionary[key];}
            set{ _dictionary[key] = value;}
        }

        //overloaded constructor
        public BasicClass(int value) : this(){
            _basicMemberVairable = value;
        }

        //params method modifier, 
        public int ParamsMethod(params int[] numbers){
            foreach(var number in numbers){
                _AutoMembervariable += number;
            }
            return _AutoMembervariable;
        }

        //ref method modifier
        public int RefMethos(ref int number){
            _AutoMembervariable = number;
            return _AutoMembervariable;
        }

        //out method modifier
        public bool OutMethod(out int a){
            a = _AutoMembervariable;
            return true;
        }

    }
}