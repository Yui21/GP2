using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatEvent : MonoBehaviour
{
    // void Start()
    // {
    //     Debug.Log("Log");
    // }
    
    public Fungus.Flowchart flowchart = null;
    public String sendMessage = "";

    private void OnTriggerEnter(Collider other)
    //private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Hit");
            flowchart.SendFungusMessage(sendMessage);
        }
        //Debug.Log("Hit");
        
    }

    //Fungusの会話スタートの設定を「Message Received」にする
}
