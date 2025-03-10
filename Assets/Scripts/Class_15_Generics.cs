using UnityEngine;
using WinG.Tools;

/// <summary>
/// 泛型 Generics
/// </summary>
public class Class_15_Generics : MonoBehaviour
{
    private void Awake()
    {
        int numberA = 7, numberB = 9;
        LogSystem.LogWithColor($"數字 A 與 B：{numberA} | {numberB}", "#f93");
        SwapNumber(ref numberA, ref numberB);
        LogSystem.LogWithColor($"數字 A 與 B：{numberA} | {numberB}", "#f93");

        char charA = '嘿', charB = '嗨';
        LogSystem.LogWithColor($"字元 A 與 B：{charA} | {charB}", "#f93");
        SwapChar(ref charA, ref charB);
        LogSystem.LogWithColor($"字元 A 與 B：{charA} | {charB}", "#f93");


        object objA = 3.5f, objB = 7.7f;
        LogSystem.LogWithColor($"物件 A 與 B：{objA} | {objB}", "#f93");
        SwapObject(ref objA, ref objB);
        LogSystem.LogWithColor($"物件 A 與 B：{objA} | {objB}", "#f93");

    }

    /// <summary>
    /// 數字對調
    /// </summary>
    /// <param name="a">第一個數字</param>
    /// <param name="b">第二個數字</param>
    public void SwapNumber(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public void SwapChar(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }

    public void SwapObject(ref object a, ref object b)
    {
        object temp = a;
        a = b;
        b = temp;
    }
}

