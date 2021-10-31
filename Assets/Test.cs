using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53; //mp

    //Magic関数
    public void Magic()
    {
        
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }

    }
}
public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 1; i <= 11; i++)
        {
            // Magic関数を呼び出す
            lastboss.Magic();
        }

        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 30;
        array[1] = 20;
        array[2] = 50;
        array[3] = 10;
        array[4] = 80;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}