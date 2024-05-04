using System;

class PrintService<T>
{
       private T[] _values = new T[10];
       private int _count = 0;

       public void AddValue(T value){
              _values[_count] = value;
              _count += 1;
       }
       public T First()
       {
              if(_count == 0)
              {
                     throw new InvalidIoperationException("PrintService is empty")
              }
              return _values[0];
       }
       public void Print(){
              Console.WriteLine(_values)
       }
}