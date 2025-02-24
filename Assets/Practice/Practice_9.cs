using UnityEngine;
using WinG.Tools;

public class Practice_9: MonoBehaviour
{
    public void Awake()
    {
        float f = -999.321f;
        sbyte sb = (sbyte)f;

        LogSystem.LogWithColor(sb, "#7f7");
    }
}
