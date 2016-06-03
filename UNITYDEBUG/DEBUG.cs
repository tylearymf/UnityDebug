using UnityEngine;
using System;

public class DEBUG
{
    public static void Log(string txt, DebugColor color)
    {
        string text = "<color=" + color.ToString() + ">" + txt + "</color>";
        Debug.Log(text);
    }

    public static void LogError(string txt, DebugColor color)
    {
        Debug.LogError("<color=" + color.ToString() + ">" + txt + "</color>");
    }

    public static void LogWarning(string txt, DebugColor color)
    {
        Debug.LogWarning("<color=" + color.ToString() + ">" + txt + "</color>");
    }
}
