using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GetOrAddComponentUtil
{
    public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
    {
        T component;
        if (gameObject.TryGetComponent<T>(out component))
        {
            return component;
        }
        else
        {
            return gameObject.AddComponent<T>();
        }
    }
}
