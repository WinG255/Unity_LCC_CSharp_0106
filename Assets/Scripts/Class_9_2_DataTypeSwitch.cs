﻿using System;
using UnityEngine;
using WinG.Tools;

/// <summary>
/// 資料類型轉換
/// </summary>
public class Class_9_2_DataTypeSwitch : MonoBehaviour
{
    private void Awake()
    {
        //隱式轉換：不需要另外宣告轉換類型
        //將小的資料放到大的資料內
        byte byte1 = 1;
        int int1=0;

        LogSystem.LogWithColor(byte1, "#7f7");
        LogSystem.LogWithColor(byte1.GetType(), "#7f7");
        LogSystem.LogWithColor(int1, "#7f7");
        LogSystem.LogWithColor(int1.GetType(), "#7f7");
        //隱式轉換：將小的byte放到大的int
        int1 = byte1;
        LogSystem.LogWithColor(int1, "#7f7");
        LogSystem.LogWithColor(int1.GetType(), "#7f7");

        //顯示轉換：需要宣告的轉換類型
        //將大的資料放到小的資料內
        int int2 = 100;
        byte byte2 = 0;
        LogSystem.LogWithColor(byte2, "#7f7");
        LogSystem.LogWithColor(byte2.GetType(), "#7f7");
        LogSystem.LogWithColor(int2, "#7f7");
        LogSystem.LogWithColor(int2.GetType(), "#7f7");
        //顯示轉換：將大的int放到小的byte
        //添加(資料類型)
        byte2 = (byte)int2;
        LogSystem.LogWithColor(byte2, "#7f7");
        LogSystem.LogWithColor(byte2.GetType(), "#7f7");

        //float轉為int，小數點會遺失
        float float1 = 3.5f;
        byte byte3 = 0;
        byte3 = (byte)float1;
        LogSystem.LogWithColor(byte3, "#7f7");
        LogSystem.LogWithColor(byte3.GetType(), "#7f7");

        //範圍較大的轉為範圍較小的，會導致溢位(從頭開始)
        int int3 = 256;
        byte byte4 = 0;
        byte4 = (byte)int3;
        LogSystem.LogWithColor(byte4, "#7f7");
        LogSystem.LogWithColor(byte4.GetType(), "#7f7");
    }

    private void Start()
    {
        //將整數轉為字串
        int count = 99;
        var intTostring = Convert.ToString(count);
        LogSystem.LogWithColor(intTostring.GetType(), "#f96");
        //將布林值轉為字串
        bool isOver = false;
        var boolToString = Convert.ToString(isOver );
        LogSystem.LogWithColor(boolToString.GetType(),"#f96");

        float move = 3.5f;
        var floatToByte = Convert.ToByte(move);
        LogSystem.LogWithColor(floatToByte.GetType(), "#f96");

        //true = 1, false = 0
        bool isGrounded = true;
        var boolToByte = Convert.ToByte(isGrounded);
        LogSystem.LogWithColor(floatToByte, "#f96");
        LogSystem.LogWithColor(floatToByte.GetType(), "#f96");
    }
}
