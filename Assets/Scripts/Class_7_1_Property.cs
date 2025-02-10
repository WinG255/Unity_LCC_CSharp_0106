using UnityEngine;

public class Class_7_1_Property:MonoBehaviour
{
    //公開變數：外部可讀、寫
    public float moveSpeed = 3.5f;
    //私人變數：外部不可讀、寫
    private float turnSpeed = 12.7f;

    //公開屬性：允許存取
    public float runSpeed { get; set; }

    //私人：不允許存取
    private float sprintSpeed {  get; set; }

    //公開：只能讀取(唯讀)
    public float jumpSpeed { get; }

    //prop + Tab
    //有預設值的屬性
    public byte lv { get; set; } = 1;

    private void Awake()
    {
        Debug.Log("-----取得變數與屬性-----");
        Debug .Log (moveSpeed);
        Debug .Log (turnSpeed);
        Debug .Log (runSpeed);
        Debug.Log (sprintSpeed);
        Debug .Log (jumpSpeed);
        Debug .Log (lv);

        Debug.Log("-----設定變數與屬性-----");
        moveSpeed = 11.1f;
        turnSpeed = 2.5f;
        runSpeed = 30;
        sprintSpeed = 60.2f;
        //jumpSpeed = 90; //沒有set，無法指定值
        lv = 10;

        
    }

    //屬性簡寫
    public float hp { get; set; } = 100;

    //屬性標準寫法
    //_mp用來裝屬性mp值的容器
    private float _mp = 50;
    public float mp
    {
        get
        {
            return _mp;
        }
        set
        {
            _mp = value;
        }
    }

    //取得屬性的簡寫 (箭頭 => Lambda)
    //唯讀屬性 防禦 值=30
    public int defence { get; } = 30;
    //唯讀屬性 攻擊 值=50
    public int attack => 50;
    private void Start()
    {
        Debug.Log($"<color=#77f>魔力：{mp}</color>");
        mp = 500;
        Debug.Log($"<color=#77f>魔力：{mp}</color>");
    }
}
