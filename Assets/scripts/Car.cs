using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float speed = 0;  //Speed變數用來設定移動的速度
    Vector2 startPos; //startPos變數用來記錄開始點擊滑鼠時的X座標與Y座標

    void Start()
    {
    }

    void Update()
    {
        //(新增)取得滑動長度
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition; //將點擊滑鼠時的座標記錄起來
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; //將放開滑鼠時的座標記錄起來
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength / 500.0f; //把滑動長度轉換成初始移動速度
            GetComponent<AudioSource>().Play(); //播放音效
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
