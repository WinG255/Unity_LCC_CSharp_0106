using UnityEngine;

/// <summary>
/// 列舉：enumeration ，c# 內關鍵字為簡寫 enum
/// </summary>
public class Class_5_2_Enumeration : MonoBehaviour
{
    #region 列舉基本用法
    //列舉：定義下拉選單的選項(通常都是單選)
    //語法：
    //修飾詞 關鍵字 enum 列舉名稱 { 列舉選項 }
    //定義一個列舉，名稱叫做季節
    //idx從0開始
    private enum Season
    {
        //定義列舉的選項
        Spring, Summer, Autumn, Winter
    }

    [SerializeField, Header("季節")]
    private Season season = Season.Summer;

    private void Awake()
    {
        //取得列舉的值(get)抓出值
        Debug.Log(season);
        //取得列舉的整數值
        Debug.Log((int)season);
        //設定列舉的值(set)修改值
        season = Season.Winter;
        Debug.Log(season);
        //透過數值設定列舉
        season = (Season)2;
        Debug.Log(season);
    } 
    #endregion

    /// <summary>
    /// 道具
    /// </summary>
    private enum Item
    {
        //可以定義idx，不能重覆，後面要比前面大
        None = 0, Coin = 1, RedWater = 10, BlueWater = 15, Chicken = 20
    }

    [SerializeField, Header("道具")]
    private Item item = Item.BlueWater;

    //執行順序：Awake > Start > Update
    //開始事件：在喚醒事件後執行一次(初始化)
    private void Start()
    {
        Debug.Log((int)item);
        Debug.Log(item);
    }
}
