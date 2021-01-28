using System;
namespace Classes
{
    public class BasicGenericList<T>
    {
        //overriden the add fucntionality
        public void Add(T value){
            throw new NotImplementedException();
        }
 
        //overridden the indexing functionality
        public T this[int index]{
            get { throw new NotImplementedException();}
        }
 
 
    }
}