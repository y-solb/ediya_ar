using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;


 
public class nextbefore : MonoBehaviour
{
    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible
    public Button nextImg; //Button to view next image
    public Button prevImg; //Button to view previous image
    public int i = 0; //Will control where in the array you are

    public GameObject obj;

    public void BreadOnButton()
    {
        obj.SetActive(true);
    }

    public void BreadOffButton()
    {
            obj.SetActive(false);
    }


    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    public void BtnPrev()
    {
        if (i - 1 > -1)
        {
            i--;
        }
     
    }

    void Update()
    {
        displayImage.sprite = gallery[i];
    }

}