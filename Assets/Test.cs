using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素数が5に配列を初期化する
        int[] array = new int[5];
        //配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 50;
        array[2] = 30;
        array[3] = 20;
        array[4] = 40;

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