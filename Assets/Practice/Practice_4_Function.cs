using UnityEngine;

public class Practice_4_Function : MonoBehaviour 
{
    private void Awake()
    {
        bool bTrue, bFalse;

        bTrue = rTrue();

        bFalse = rFalse();

        Debug.Log($"回傳1：{bTrue}，回傳2：{bFalse}");
    }
       
    private bool rTrue()
    {
        return true;
    }

    private bool rFalse()
    {
        return false;
    }
}
