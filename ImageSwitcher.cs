using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public GameObject[] images;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    void Update()
    {
        if (index == 4)
            images[6].gameObject.SetActive(false);
        else if (index == 0)
        {
            images[5].gameObject.SetActive(false);
            images[0].gameObject.SetActive(true);
        }
        else
        {
            images[5].gameObject.SetActive(true);
            images[6].gameObject.SetActive(true);
        }

    }

    public void Next()
    {
        index++;

        images[index - 1].gameObject.SetActive(false);
        images[index].gameObject.SetActive(true);
    }

    public void Previous()
    {
        index--;

        images[index + 1].gameObject.SetActive(false);
        images[index].gameObject.SetActive(true);
    }
}
