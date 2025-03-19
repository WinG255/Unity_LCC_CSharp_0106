using System;
using UnityEngine;
using WinG.Tools;

/// <summary>
/// 例外處理
/// </summary>
public class Class_18_Exception : MonoBehaviour 
{
    private void Awake()
    {
        #region 例外處理
        LogSystem.LogWithColor($"{Division(8, 4)}", "#f33");
        LogSystem.LogWithColor($"{Division(3, 9)}", "#f33");
        LogSystem.LogWithColor($"{Division(7, 0)}", "#f33");

        LogSystem.LogWithColor($"{GetScores(0)}", "#3f3");
        LogSystem.LogWithColor($"{GetScores(4)}", "#3f3");
        LogSystem.LogWithColor($"{GetScores(9)}", "#3f3");

        SetEnemy();
        #endregion

        //自訂例外使用try catch，才不會有紅色驚嘆號
        try
        {
            Damage(35);
            Damage(70);
        }
        catch (Exception e)
        {
            LogSystem.LogWithColor(e, "#fa9");
        }

        try
        {
            Cure(30);
            Cure(-10);
        }
        catch (CureValueLowerZeroException e)
        {
            LogSystem.LogWithColor(e.Message, "#7f3");
        }
    }

    #region 例外處理
    /// <summary>
    /// 除法
    /// </summary>
    /// <param name="numA">分母</param>
    /// <param name="numB">分子</param>
    /// int? 允許回傳空值
    private int? Division(int numA, int numB)
    {
        try
        {
            return numA / numB;
        }
        catch (DivideByZeroException)
        {
            //例外，除以0
            LogSystem.LogWithColor("分子不能為0", "#f99");
            return null;
        }
        finally
        {
            //最後處理區域，可省略
            LogSystem.LogWithColor("例外處理完畢", "#f73");
        }
    }

    private int[] scores = { 70, 91, 64, 53, 88 };
    private int? GetScores(int index)
    {
        try
        {
            return scores[index];
        }
        catch (DivideByZeroException)
        {
            LogSystem.LogWithColor("發生例外", "#f11");
            return null;
        }
        catch (IndexOutOfRangeException e)
        {
            //例外帶訊息
            LogSystem.LogWithColor($"發生例外 | {e.Message}", "#f11");
            return null;
        }
    }

    [SerializeField]
    private GameObject enemy;

    /// <summary>
    /// 設定敵人物件
    /// </summary>
    private void SetEnemy()
    {
        try
        {
            enemy.SetActive(true); //顯示敵人物件
        }
        catch (Exception e)
        {
            //Exception 處理所有例外
            LogSystem.LogWithColor($"發生例外:{e.Message}", "#f39");
        }
    }
    #endregion

    private float hp = 100;
    private void Damage (float damage)
    {
        hp -= damage;
        if (hp <0)
        {
            //自訂例外
            throw new Exception("血量小於0");
        }
        else
        {
            LogSystem.LogWithColor($"血量:{hp}", "#93f");
        }
    }

    private void Cure (float cure)
    {
        if (cure < 0)
        {
            //throw new Exception("治療值低於0");
            throw new CureValueLowerZeroException("治療值低於0");
        }
        else
        {
            hp += cure;
        }
    }
}

/// <summary>
/// 
/// </summary>
public class CureValueLowerZeroException : Exception
{
    /// <summary>
    /// 建構子
    /// </summary>
    /// <param name="message">傳入訊息</param>
    public CureValueLowerZeroException (string message) : base(message)
    {

    }
}
