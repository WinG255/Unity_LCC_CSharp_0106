using UnityEngine;

public class Practice_7_Property : MonoBehaviour
{
    //public int hp { get; }=0;

    //private void Awake()
    //{
    //    Debug.Log($"<color=#fff>血量：{hp}</color>");

    //    if( hp <= 0 )
    //    {
    //        Debug.Log($"<color=#fff>血量：{hp}，您已死亡。</color>");
    //    }
    //}


    //老師寫法
    [SerializeField]
    private float _hp = 100;

    public float hp
    {
        get
        {
            if (_hp <=0)
            {
                Debug.Log($"<color=#fff>血量：{hp}，您已死亡。</color>");
            }
            return _hp;
        }
    }

    private void Update()
    {
        Debug.Log(hp);
    }
}
