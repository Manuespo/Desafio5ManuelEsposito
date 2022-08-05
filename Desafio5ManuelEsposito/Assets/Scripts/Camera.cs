using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cameras;
    int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            i++;
            if (i == cameras.Length)
                i = 0;

            switch (i)
            {
                case 0:{ cameras[0].SetActive(true);
                        cameras[1].SetActive(false);
                    }
                    break;
                case 1:{
                        cameras[0].SetActive(false);
                        cameras[1].SetActive(true);
                    }
                    break;
            }
        }
    }
}
