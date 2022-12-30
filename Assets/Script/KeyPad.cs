using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //UIが関わってくるため

public class KeyPad : MonoBehaviour
{
    [SerializeField] private Text Ans;

    private string Answer = "0630";
    
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "OK!";
            gameObject.SetActive (false);
        }
        else
        {
            Ans.text = "Error";
        }
    }

    public void Delete()
    {
        Ans.text = "";
    }
}
