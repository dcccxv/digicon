using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageView5 : MonoBehaviour
{
    public int photo = 0;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("showUI", 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (photo == 1)
            {
                UI.SetActive(false);
                photo = 0;
            }
            else
            {
                showUI();
            }
        }
    }

    void showUI()
    {
        UI.SetActive(true);
        photo = 1;
    }
}
