using System;

namespace Classes
{
    public class DerivedClass : BasicClass
    {
        public void DerivedMethod(){
            
            Console.WriteLine("This is a method of the derived class {0} is a var from the base class",_basicMemberVairable);
        }
    }
}