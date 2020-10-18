using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bread : MonoBehaviour
{
    public GameObject obj;

    public void BreadOnButton()
    {
        obj.SetActive(true);
    }

    public void BreadOffButton()
    {
        obj.SetActive(false);
    }

}
