using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 使用 UI 物件，必須增加此處理程序

public class GameManager : MonoBehaviour
{
    GameObject car;              // 用來儲存汽車物件
    GameObject flag;             // 用來儲存旗子物件
    GameObject distance;         // 用來儲存UI文字物件
    GameObject Score;       //用來儲存分數文字物件
    void Start() // 將場景中的物件放到已宣告的各個物件中
    {
        car = GameObject.Find("car");         
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        Score = GameObject.Find("Score");
        Debug.Log("Hello World");
    }

    void Update()
    {
        // 計算旗子與汽車的距離
        float length = flag.transform.position.x - car.transform.position.x;
        // 將旗子與汽車的距離顯示在UI上面
        distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + "m";
        float ScoreNumber = 100 / length;//分數計算
        if (length < 0)
            ScoreNumber = 0;
        if (ScoreNumber > 100)
            ScoreNumber = 100;
        Score.GetComponent<Text>().text = "分數 " + ScoreNumber.ToString("F2") + "分";
        
    }
    
}
