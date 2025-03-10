using UnityEngine;
using WinG.Tools;

public class Class_15_Interface : MonoBehaviour 
{
    public object invertoryFirst;
    public object invertorySecond;

    private void Awake()
    {
        int random = Random.Range(0, 3);
        LogSystem.LogWithColor($"隨機：{random}", "#f33");

        if (random == 0) invertoryFirst = new Prop();
        else if (random == 1) invertoryFirst = new Equipment1();
        else if (random == 2) invertoryFirst = new Map();

        int randomSecond = Random.Range(0, 3);

        if (randomSecond == 0) invertorySecond = new Weapon();
        else if (randomSecond == 1) invertorySecond = new Potion1();
        else if (randomSecond == 2) invertorySecond = new Chest();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //如果第一格是道具，就使用道具
            if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();
            //如果第一格是裝備，就使用裝備
            else if (invertoryFirst is Equipment1) ((Equipment1)invertoryFirst).Use();
            //如果第一格是地圖，就使用地圖
            else if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

            //當遊戲的物品種類變多的時候，這邊的判斷式會很恐怖
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // 如果第二格道具的物品有實作介面，就使用
            if (invertorySecond is IUse) ((IUse)invertorySecond).Use();

            //如果擴充物品，判斷式不需要添加，只需要讓物品都實作介面即可
        }
    }
}


public class Prop
{
    public void Use()
    {
        LogSystem.LogWithColor("使用道具", "#fa3");
    }
}

public class Equipment1
{
    public void Use()
    {
        LogSystem.LogWithColor("使用裝備", "#fa3");
    }
}

public class Map
{
    public void Use()
    {
        LogSystem.LogWithColor("使用地圖", "#fa3");
    }
}