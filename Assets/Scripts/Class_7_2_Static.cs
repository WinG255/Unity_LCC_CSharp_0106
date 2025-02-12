using UnityEngine;

/// <summary>
/// 靜態
/// </summary>
public class Class_7_2_Static:MonoBehaviour
{
    //非靜態變數
    public int inventoryWater = 10;

    //靜態變數：修飾詞後面添加關鍵字 static
    //靜態變數不顯示在屬性面版上
    public static int inventoryProp = 20;

    private float attack = 10;
    private static float mp = 100;

    private void Awake()
    {
        inventoryWater = 7;
        inventoryProp = 15;
        Debug.Log($"<color=#f31>藥水：{inventoryWater}</color>");
        Debug.Log($"<color=#f31>道具：{inventoryProp}</color>");
    }

    private void Punch()
    {
        Debug.Log("<color=#3f3>使用拳擊</color>");
        //非靜態方法內可以存取所有成員
        Debug.Log($"<color=#3f3>非靜態攻擊力：{attack}</color>");
        Debug.Log($"<color=#3f3>靜態魔力：{mp}</color>");
    }

    public static void Kick()
    {
        Debug.Log("<color=#3f3>靜態方法：使用踢擊</color>");
        //靜態方法內只能存取靜態成員
        //由於attack 是非靜態所以無法存取(導致錯誤)
        //Debug.Log($"<color=#f9e>非靜態魔力：{attack}</color>");
        Debug.Log($"<color=#f9e>靜態魔力：{mp}</color>");

    }

    private void Start()
    {
        

    }

    private void Update()
    {
        
    }
}
