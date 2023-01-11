using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatEvent : MonoBehaviour
{
    public Fungus.Flowchart flowchart = null;
    public String sendMessage = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit");
            flowchart.SendFungusMessage(sendMessage);
        }
        
    }

    //Fungusの会話スタートの設定を「Message Received」にする
}
