using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    GameObject status,bg, player;
    float time1 = 0f;

    void Start()
    {
        this.status = GameObject.Find("Canvas/statusText");
        this.bg = GameObject.Find("bg");
        this.player = GameObject.Find("fish");
    }
    void Update()
    {
        Sprite WinBg = Resources.Load<Sprite>("WinBg");
        Sprite mainBg = Resources.Load<Sprite>("mainBg");

        float time2 = 20 - (int)time1;
        if (time2 <= 0&& this.status.GetComponent<Text>().text != "再玩一次")
        {
            GetComponent<Text>().text = "Win";
            this.bg.GetComponent<SpriteRenderer>().sprite = WinBg;
          //  this.status.GetComponent<Text>().text = "再玩一次";
        }else if(this.status.GetComponent<Text>().text == "再玩一次"
            && this.bg.GetComponent<SpriteRenderer>().sprite == WinBg)
        {
            time1 = 0;
        }
        else if(this.status.GetComponent<Text>().text == "再玩一次"
            && this.bg.GetComponent<SpriteRenderer>().sprite != mainBg
             && this.bg.GetComponent<SpriteRenderer>().sprite != WinBg)
        {
            GetComponent<Text>().text = "Game Over";
            time1 = 0;
        }
        else
        {            
            GetComponent<Text>().text = "" + time2;    // 前面加空字串，是為了把 整數a 轉為 字串。
            time1 += Time.deltaTime;
        }
    }
}
