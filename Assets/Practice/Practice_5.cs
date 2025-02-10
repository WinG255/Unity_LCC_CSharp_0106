using UnityEngine;

public class Practice_5 : MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    private int blood = 100;

    private void Awake()
    {

    }

    private void Update()
    {
        switch (blood)
        {
            case >= 80:
                Debug.Log("<color=#aff>血量安全</color>");
                break;
            case >= 60:
                Debug.Log("<color=#aff>健康狀態有狀況</color>");
                break;
            case >= 40:
                Debug.Log("<color=#aff>警告，快喝水</color>");
                break;
            case >= 10:
                Debug.Log("<color=#aff>快死掉了</color>");
                break;
            case 0:
                Debug.Log("<color=#aff>你已經死了</color>");
                break;
        }
    }
}
