using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DemoToolbox;

[CustomEditor(typeof(DemoToolboxSampleScript))]
public class DemoToolboxSampleScriptEditor : Editor
{
    override public void OnInspectorGUI()
    {
        if (GUILayout.Button("Test"))
        {
            string[] arr = new string[] { "Foo", "Bar" };
            Debug.Log(arr.RandomElement());
        }
    }
}
