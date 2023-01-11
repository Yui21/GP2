using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //UIが関わってくるため

public class TransApp : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    
    private string Input1 = "riropo";
    private string Answer1 = "こんにちは";

    private string Input2 = "repororo";
    private string Answer2 = "はじめまして";

    private string InputDG = "popopo";
    private string AnswerDG = "お腹すいた";
 
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

        else if(inputField.text == InputDG)
        {
            text.text = AnswerDG;
        }
    }
}
