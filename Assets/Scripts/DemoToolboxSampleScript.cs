using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DemoToolbox;

public class DemoToolboxSampleScript : MonoBehaviour
{
    public void FooBar()
    {
        string[] arr = new string[] {"Foo", "Bar" };
        arr.RandomElement();
    }
}
