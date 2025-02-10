using UnityEngine;

/// <summary>
/// 陣列 array
/// </summary>
public class Class_6_2_Array : MonoBehaviour
{
    //不使用陣列的寫法：
    public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

    //使用陣列的寫法：
    //陣列：用來儲存多筆相同類型的資料
    //第一種：不指定值，透過unity 面版輸入
    //修飾詞 資料類型[] 陣列名稱：
    public string[] cards;

    //第二種：直接定義陣列的數量
    //定義一種牌組1，可以卡五張卡牌
    public string[] deck1 = new string[5];
    //第二種：直接定義陣列的值
    public string[] deck2 = { "急凍鳥","賭霞","寶石海星" };

    //二維陣列
    public string[,] inventory = { {"紅水","藍水" },{"炸彈","金幣" }};
    //public string[][] temp = new string[2][] [[" "," " ],[" "," " ]];

    //三維陣列
    public string[,,] shop =
    {
        { 
            { "小刀", "美工刀" },{ "武士刀", "屠龍刀" } 
        }, 
        { 
            { "精靈球", "高級球" },{ "大師球", "巢穴球" } 
        } 
    };

    private void Awake()
    {
        #region 一維陣列
        ////存取陣列 set、get
        ////get 取得陣列的資料
        ////陣列名稱[編號]
        ////這邊直接執行會有錯，因為Cards 沒有值，需在unity畫面手動輸入
        //Debug.Log($"<color=#f32>Cards 的第三張卡片：{cards[2]}</color>");
        ////超出陣列範圍，會導致錯誤
        ////錯誤會導致當機、閃退、不符合預期的結果或者不執行下方程式
        ////Debug.Log($"<color=#f32>Cards 的第四張卡片：{cards[3]}</color>");

        ////set 設定陣列的資料
        ////陣列名稱[編號] 指定值;
        //deck2[2] = "傑尼龜";
        //Debug.Log($"<color=#f32>deck2 的第三張卡片：{deck2[2]}</color>");
        #endregion

        #region 二維陣列
        //存取二維陣列
        Debug.Log($"<color=#3f3>編號[0,1]道具：{inventory[0,1]}</color>");

        inventory[1, 1] = "金創藥";
        Debug.Log($"<color=#3f3>編號[1,1]道具：{inventory[1, 1]}</color>");
        #endregion

        #region 三維陣列
        //存取三維陣列
        //取得屠龍刀
        Debug.Log($"<color=#f3d>第一頁第二排第二個：{shop[0,1,1]}</color>");
        //設定高級球為起級球
        shop[1, 0, 1] = "超級球";
        Debug.Log($"<color=#f3d>第二頁第一排第二個：{shop[1, 0, 1]}</color>");
        #endregion

        //獲得陣列的長度或維度
        //一維陣列的長度：陣列名稱.Length
        Debug.Log($"<color=#f93>一維-牌組2的長度：{deck2.Length}</color>");
        Debug.Log($"<color=#f93>二維-道具的長度：{inventory.Length}</color>");
        Debug.Log($"<color=#f93>三維-商品的長度：{shop.Length}</color>");

        //陣列的維度：陣列名稱.Rank
        Debug.Log($"<color=#f93>一維-牌組2的維度：{deck2.Rank}</color>");
        Debug.Log($"<color=#f93>二維-道具的維度：{inventory.Rank}</color>");
        Debug.Log($"<color=#f93>三維-商品的維度：{shop.Rank}</color>");
    }
}
