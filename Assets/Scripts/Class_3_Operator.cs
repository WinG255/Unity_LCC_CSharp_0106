using UnityEngine;

/// <summary>
/// 課程3：運算子
/// 欄位屬性、事件
/// </summary>
public class Class_3_Operator : MonoBehaviour 
{
    //CTRL+R+R 快速更檔名，會連結到unity

    #region 基本欄位屬性
    //變數 = 欄位 Field
    //欄位屬性 Field Attritube
    //[標題(標題文字)]
    [Header("等級")]
    public int Lv = 1;

    //[提示(提示文字)]
    [Header("移動速度")]
    [Tooltip("滑鼠移到上面顯示的提示框")]
    public float moveSpeed = 2.5f;

    //[範圍(min,max)]：限數字類的使用，面板上會變為滑桿顯示
    [Range(1, 100)]
    public byte count = 10;

    //[文字框行數(min,max)]
    [TextArea(2, 5)]
    public string Descript = "多文字的備註說明";

    //多個欄位屬性
    //基本寫法
    [Header("血量")]
    [Range(0, 999)]
    public int hp = 100;
    //進階寫法，用逗號隔開
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 30.5f;

    //[在屬性面板隱藏]：將公開變數隱藏
    [HideInInspector]
    public string passwd = "密碼";
    //[序列化欄位]：將私人變數顯示
    [SerializeField]
    private float mp = 500;
    #endregion

    //使用 Unity 的事件
    //1.必需在腳本後面添加：MonoBehaviour(繼承)
    //2.使用關鍵字快速完成，例如：輸入Awake挑選要使用的事件按Enter
    //喚醒事件：播放遊戲後會執行的第一個事件，只執行一次
    //事件名稱是藍色的(沒有變色不影響)
    private void Awake()
    {
        #region 輸出訊息
        //將小括號內的訊息輸出到Unity的Console控制面版
        //Ctrl+Shift+C開啟控制台面版
        Debug.Log("Hello!");

        Debug.Log(hp);

        //以下兩者寫法結果相同
        Debug.Log("攻擊力："+attack );
        Debug.Log($"攻擊力：{attack}");
        Debug.Log("攻擊力：{attack}");//漏了前面的$，後面的{attack}會變成文字顯示

        Debug.Log("<b>粗體</b>");
        //色碼：#紅紅綠綠藍藍，數值：0~9，a~f，越右邊顏色越亮 #000 黑 #fff 白
        Debug.Log("<color=orange>橘色</color>");

        Debug.Log("<color=#66aaff>藍色</color>");
        Debug.Log("<color=#6af>藍色</color>"); //簡碼
        #endregion

        #region 算術運算子
        Debug.Log("<color=#f93>--- 算術運算子 ---</color>");
        //運算子：
        //1.算術運算子
        //加、減、乘、除、餘
        //+、-、*、/、%
        Debug.Log(10 + 3);
        Debug.Log(10 - 3);
        Debug.Log(10 * 3);
        Debug.Log(10 / 3);
        Debug.Log(10 % 3);

        Debug.Log("<color=#f93>--- 算術運算子：區域變數 ---</color>");
        //區域變數：僅在此大括號內存取(不需要修飾詞的變數)
        float num1 = 10;
        float num2 = 3;

        Debug.Log(num1 + num2);
        Debug.Log(num1 - num2);
        Debug.Log(num1 * num2);
        Debug.Log(num1 / num2);
        Debug.Log(num1 % num2);
        #endregion

        #region 比較運算子
        Debug.Log("<color=#f93>--- 比較運算子 ---</color>");
        //比較運算子，回傳布林
        int num3 = 100, num4 = 1;

        Debug.Log(num3 > num4);
        Debug.Log(num3 < num4);
        Debug.Log(num3 >= num4);
        Debug.Log(num3 <= num4);
        Debug.Log(num3 == num4); //等於
        Debug.Log(num3 != num4); //不等於
        #endregion 
    }
}
