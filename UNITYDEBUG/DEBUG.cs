using UnityEngine;

/// <summary>
/// UNITYDEBUG
/// </summary>
public class DEBUG
{
    /// <summary>
    /// Log
    /// </summary>
    /// <param name="txt"></param>
    /// <param name="color"></param>
    public static void Log(string txt, DebugColor color)
    {
        string text = "<color=" + color.ToString() + ">" + txt + "</color>";
        Debug.Log(text);
    }

    /// <summary>
    /// LogError
    /// </summary>
    /// <param name="txt"></param>
    /// <param name="color"></param>
    public static void LogError(string txt, DebugColor color)
    {
        Debug.LogError("<color=" + color.ToString() + ">" + txt + "</color>");
    }

    /// <summary>
    /// LogWarning
    /// </summary>
    /// <param name="txt"></param>
    /// <param name="color"></param>
    public static void LogWarning(string txt, DebugColor color)
    {
        Debug.LogWarning("<color=" + color.ToString() + ">" + txt + "</color>");
    }
}
