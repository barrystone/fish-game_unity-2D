using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statusSeting : MonoBehaviour
{

    GameObject player,bg, canvas, timer;
    void Start()
    {
        this.player = GameObject.Find("fish"); 
        this.bg = GameObject.Find("bg");
        this.timer = GameObject.Find("Canvas/Text");
    }

    void Update()
    {
        Vector3 Sca = this.player.transform.localScale;

        string status = Sca.ToString();
        char[] delimiterChars = { '(', ')', ' ', ',' };
        string[] words = status.Split(delimiterChars);

        float firstScale = float.Parse(words[1]);
        float secondScale = float.Parse(words[3]);

        Sprite fish = Resources.Load<Sprite>("fish");
        Sprite fullFish = Resources.Load<Sprite>("fullFish");
        Sprite dieFish = Resources.Load<Sprite>("dieFish");
        Sprite dish = Resources.Load<Sprite>("dish");
        Sprite mainBg = Resources.Load<Sprite>("mainBg");
        Sprite overBg = Resources.Load<Sprite>("overBg");


        //   GetComponent<Text>().text = $"{firstScale} {secondScale}";
      if ( this.timer.GetComponent<Text>().text == "Win")
        {
            this.player.GetComponent<SpriteRenderer>().sprite = dish;
            GetComponent<Text>().text = "再玩一次";
        }
        else
        {
            this.bg.GetComponent<SpriteRenderer>().sprite = mainBg;
            this.player.GetComponent<SpriteRenderer>().sprite = fish;
            if (firstScale > 0.85f && secondScale > 0.85f)
            {
                GetComponent<Text>().text = "好撐!!";
                if (firstScale > 1.1f && secondScale > 1.1f)
                {
                    this.player.GetComponent<SpriteRenderer>().sprite = fullFish;
                    this.bg.GetComponent<SpriteRenderer>().sprite = overBg;
                    GetComponent<Text>().text = "再玩一次";
                }
            }
            else if (firstScale < 0.6f && secondScale < 0.6f)
            {
                GetComponent<Text>().text = "餓扁了!!";
                if (firstScale < 0.4f && secondScale < 0.4f)
                {
                    this.player.GetComponent<SpriteRenderer>().sprite = dieFish;
                    this.bg.GetComponent<SpriteRenderer>().sprite = overBg;
                    GetComponent<Text>().text = "再玩一次";
                }
            }
            else
            {
                GetComponent<Text>().text = "舒服";
            }
        }
    }
}
