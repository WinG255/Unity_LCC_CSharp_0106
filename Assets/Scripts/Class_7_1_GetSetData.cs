using Unity.Properties;
using UnityEngine;

public class Class_7_1_GetSetData:MonoBehaviour
{
    public Class_7_1_Property property;

    private void Awake()
    {
        //取得另一個類別的資料
        Debug.Log(property.moveSpeed);
        //Debug.Log(property.turnSpeed); //私人無法存取

        //設定另一個類別的資料
        property.moveSpeed = 7.7f;
        //property.turnSpeed = 20.2f; //私人無法存取

        Debug.Log(property.runSpeed );

        property.runSpeed = 50.3f;
        //property.jumpSpeed = 99.5f; //唯讀，不可指定資料
        //property.jumpSpeed = 99.5f; //唯讀，不可指定資料
    }
}
