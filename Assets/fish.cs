using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fish : MonoBehaviour
{
    GameObject status;
    float time=0f;
    float cutSize;
    void Start()
    {
        this.status = GameObject.Find("Canvas/statusText");
    }
    void Update()
    {  

        if (this.status.GetComponent<Text>().text != "再玩一次")
        {   
            GetComponent<Transform>().localScale -= new Vector3(cutSize, cutSize, 1);
            time += Time.deltaTime;
            cutSize = time / 20000;

            if (Input.GetKey("up")) { transform.Translate(0, 0.2f, 0); }

            if (Input.GetKey("down")) { transform.Translate(0, -0.2f, 0); }

            if (Input.GetKey("left")) { transform.Translate(-0.2f, 0, 0); }

            if (Input.GetKey("right")) { transform.Translate(0.2f, 0, 0); }
        }
        else
        {
            time = 0;
        }       
    }
}
