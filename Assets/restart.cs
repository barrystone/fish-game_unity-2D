using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class restart : MonoBehaviour
{
    GameObject status, bg, player;
    void Start()
    {
        this.status = GameObject.Find("Canvas/statusText");
        this.bg = GameObject.Find("bg");
        this.player = GameObject.Find("fish");
       
    }
    public void Click()
    {
        Sprite mainBg = Resources.Load<Sprite>("mainBg");
        Sprite fish = Resources.Load<Sprite>("fish");

        this.player.GetComponent<Transform>().localScale = new Vector3(0.7f,0.7f,1);
        this.player.GetComponent<Transform>().position = new Vector3(-9.5f, -4, 1); ;
        this.status.GetComponent<Text>().text = "舒服";
        this.bg.GetComponent<SpriteRenderer>().sprite = mainBg;
        this.player.GetComponent<SpriteRenderer>().sprite = fish;

    }
}
