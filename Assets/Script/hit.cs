using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public String sendMessage = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            flowchart.SendFungusMessage(sendMessage);
        }
    }
}
