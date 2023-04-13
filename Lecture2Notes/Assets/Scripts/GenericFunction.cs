using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFunction<T> 
{
   
    static void exchange(T valueA, T valueB)
    {
        T temp;
        temp = valueA;
        valueA = valueB;
        valueB = temp;
    }
}
