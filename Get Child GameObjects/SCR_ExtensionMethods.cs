using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Danndx 2022 (youtube.com/danndx)
From video: youtu.be/KhvokgokrQE
thanks - delete me! :) */


public static class SCR_ExtensionMethods
{
    public static List<Transform> GetChildren(this GameObject gameobject, bool recursive)
    {
        /** Get a list of children from a given gameobject, either the direct
            descendants or all recursively. **/

        List<Transform> children = new List<Transform>();

        foreach(Transform child in gameobject.transform)
        {
            children.Add(child);
            if(recursive)
            {
                children.AddRange(GetChildren(child.gameObject, true));
            }
        }

        return children;
    }

    public static Dictionary<Transform, dynamic> GetChildrenHierarchy(this GameObject gameobject)
    {
        /** Get a dictionary hierarchy of all children under a given gameobject. **/

        Dictionary<Transform, dynamic> children = new Dictionary<Transform, dynamic>();

        foreach(Transform child in gameobject.transform)
        {
            children.Add(child, GetChildrenHierarchy(child.gameObject));
        }

        return children;
    }
}
