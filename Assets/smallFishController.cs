using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smallFishController : MonoBehaviour
{
    GameObject player,status;

    float span = 2;
    float delta = 0;

    void Start()
    {
        this.player = GameObject.Find("fish");  
        this.status = GameObject.Find("Canvas/statusText");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = transform.position;              
        Vector2 p2 = this.player.transform.position;  
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  
        double r2 = this.player.transform.localScale.x*2.5;  // 遊戲角色的圓半徑

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            Destroy(gameObject);
        }
        if (d < r1 + r2)
        {
            this.player.transform.localScale += new Vector3(0.1f, 0.1f, 0);
            Destroy(gameObject);
        }
        if (this.status.GetComponent<Text>().text == "再玩一次")
        {
            Destroy(gameObject);
        }
    }
}
