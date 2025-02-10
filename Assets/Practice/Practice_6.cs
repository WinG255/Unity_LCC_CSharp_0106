using JetBrains.Annotations;
using UnityEngine;

public class Practice_6:MonoBehaviour
{
    public string[,,] arr =
    {
        {
            { "皮卡丘","傑尼龜","妙娃種子"},
            { "胖丁","小火龍","卡比獸"}
        },
        {
            { "藍水靈","菇菇寶貝","肥肥"},
            { "黑木妖","藍寶","青蛇"}
        },
        {
            { "提摩","伊澤瑞爾","維克特"},
            { "阿卡莉","蓋倫","米里歐"}
        }
    };

    private void Awake()
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    if (arr[i, j, k] == "皮卡丘")
                    {
                        Debug.Log($"<color=#f3d>皮卡丘位置：{i.ToString()+","+j.ToString()+","+k.ToString()}</color>");
                    }
                    else if (arr[i, j, k] == "菇菇寶貝")
                    {
                        Debug.Log($"<color=#f3d>菇菇寶貝位置：{i.ToString() + "," + j.ToString() + "," + k.ToString()}</color>");
                    }
                    else if (arr[i, j, k] == "蓋倫")
                    {
                        Debug.Log($"<color=#f3d>蓋倫位置：{i.ToString() + "," + j.ToString() + "," + k.ToString()}</color>");
                    }
                }
            }
        }

        Debug.Log($"<color=#f3d>第二頁第一排第三個：{arr[1, 0, 2]}</color>");
    }

    private void Update()
    {
        
    }
}
