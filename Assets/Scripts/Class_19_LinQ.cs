using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using WinG.Tools;
using static UnityEditor.Progress;

/// <summary>
/// LinQ 整合查詢語言 Language Integrated Query
/// 查詢資料庫，所有程式語言共用技術
/// </summary>
public class Class_19_LinQ : MonoBehaviour 
{

    public int[] scores = { 90,88,76,68,92,59};
    public string[] items = {"","" };

    private void Awake()
    {
        #region LinQ基本用法
        //使用LinQ 的關鍵字查詢資料
        //起手式：
        //from 資料來源
        //select 選取結果
        //說明：選取 scores 內的每一筆分數
        var queryAllData = from score in scores select score;

        foreach (var item in queryAllData)
        {
            LogSystem.LogWithColor(item, "#3f3");
        }

        //情境：希望找到大於 60 分的玩家分數並且排序
        // where 篩選的條件
        //descending
        var querySixty = from score in scores where score >= 60 orderby score descending select score;

        foreach (var item in querySixty)
        {
            LogSystem.LogWithColor(item, "#ff3");
        }

        //情境：篩選出分數為偶數的資料與奇數
        //group by 
        var queryGroup = from score in scores group score by score % 2;

        foreach (var group in queryGroup)
        {
            LogSystem.LogWithColor(group, "#f11");

            foreach (var item in group)
            {
                LogSystem.LogWithColor(item, "#79f");
            }

            LogSystem.LogWithColor("--------------------------------------------", "#79f");
        }
        #endregion

        var queryRed = from item in items
                       lef firstWord = item[0]
                        where firstWord == '紅'
            select item;

        foreach (var group in queryRed)
        {
            LogSystem.LogWithColor($"第一個字是紅到道具:{item}", "#fa3");
        }

        var queryRedGroup = from item in items
                            group item by item[0] into newGroup
                            select newGroup;

        foreach (var group in queryRedGroup)
        {
            LogSystem.LogWithColor($"群組:{group.Key}", "#3f3");
            foreach (var item in queryRedGroup)
            {
                LogSystem.LogWithColor($"道具:{item}", "#9f9");
            }
        }
    }
}

