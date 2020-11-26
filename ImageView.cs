using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageView : MonoBehaviour
{
    private int photo = 0;
    public int state = 0;
    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;
    public GameObject UI4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            if(photo == 1)
            {
                    UI1.SetActive(false);
                    UI2.SetActive(false);
                    UI3.SetActive(false);
                    UI4.SetActive(false);
                    photo = 0;
            }
            else
            {
                showUI();
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "clear")
        {
            state++;
            Invoke("showUI", 2);
        }
    }

    void showUI()
    {
        if (state == 1)
        {
            UI1.SetActive(true);
            photo = 1;
        }
        else if (state == 2)
        {
            UI2.SetActive(true);
            photo = 1;
        }
        else if (state == 3)
        {
            UI3.SetActive(true);
            photo = 1;
        }
        else if (state == 4)
        {
            UI4.SetActive(true);
            photo = 1;
        }
    }
}
