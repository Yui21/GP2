using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //UIが関わってくるため

public class TransApp : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    
    public string Input1 = "pipipi";
    public string Answer1 = "こんにちは";

    public string Input2 = "popopo";
    public string Answer2 = "お腹すいた";
 
    void Start () {
    //Componentを扱えるようにする
    inputField = inputField.GetComponent<InputField> ();
    text = text.GetComponent<Text> ();
    }
 
    public void InputText(){
    //テキストにinputFieldの内容を反映
        
        //Input1の言葉が入力されたら
        if(inputField.text == Input1)
        {
            //Answer1の答えを表示
            //pipipi = こんにちは、の翻訳
            text.text = Answer1;
        }

        else if(inputField.text == Input2)
        {
            text.text = Answer2;
        }
    }
}
