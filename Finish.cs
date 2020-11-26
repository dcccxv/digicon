using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject UI;
    public string timerTime = "";
    public Text connectionInfoText;
    public Text connectionInfoText2;
    public int count = 0;


    System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
    
    void Start()
    {
        watch.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Car")
        {
            if (watch.IsRunning)
            {
                watch.Stop();
            }
            UI.SetActive(true);
            timerTime = watch.Elapsed.ToString().Substring(0,8);
            connectionInfoText.GetComponent<Text>().text = "소요시간: " + timerTime;
            connectionInfoText2.GetComponent<Text>().text = "재도전횟수: " + count.ToString();

            Destroy(gameObject, 0.5f);
        }
    }
}
