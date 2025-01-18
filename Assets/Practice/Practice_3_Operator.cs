using UnityEngine;

public class Pracitice_3_Operator : MonoBehaviour 
{
    private void Awake()
    {
        int num1,num2,num3,num;

        num1 = 6;
        num2 = 2;
        num3 = 1;

        num = num1 / num2 * (num3+num2);

        Debug.Log(num);
    }
}
