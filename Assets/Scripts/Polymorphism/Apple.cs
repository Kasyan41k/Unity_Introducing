using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polymorphism
{
    public class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("1st Apple Constructor Called");
        }

        public new void Chop()
        {
            Debug.Log("The apple has been chopped.");
        }

        public new void SayHello()
        {
            Debug.Log("Hello, I am an apple.");
        }
    }
}

