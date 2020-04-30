using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smallFishGenerator : MonoBehaviour
{
    GameObject status;
    public GameObject smallFishPrefab;
    float span = 0.5f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.status = GameObject.Find("Canvas/statusText");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span&&this.status.GetComponent<Text>().text != "再玩一次")
        {
            this.delta = 0;
            GameObject smallFishObject = Instantiate(smallFishPrefab) as GameObject;
            int px = Random.Range(-13, 13);
           int py = Random.Range(-6, 6);
            smallFishObject.transform.position = new Vector3(px, py, 0);
            // smallFishObject.transform.position = new Vector3(1, 1, 0);
        }
    }
}
