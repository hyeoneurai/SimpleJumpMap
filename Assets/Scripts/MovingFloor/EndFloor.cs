using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFloor : MonoBehaviour
{
    public GameObject panel;

    public void OnTriggerEnter(Collider other)
    {
        panel.SetActive(true);
    }
}
