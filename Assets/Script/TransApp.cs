using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //UIが関わってくるため

public class TransApp : MonoBehaviour
{
    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    
    //Scene03でモナが言う
    private string Input1 = "riropo";
    private string Answer1 = "こんにちは";

    //Scene03でアイが言う
    private string Input2 = "repororo";
    private string Answer2 = "はじめまして";

    //Scene05でモナが言う
    private string Input3 = "ropoporipipara";
    private string Answer3 = "奥の森で光る物を見たことがあるよ";

    //Scene05でアイが言う
    private string Input4 = "piripiroreperiporipipi";
    private string Answer4 = "輝く絵本の色は絶対に消えない";

    //デバッグ用
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

        else if(inputField.text == Input3)
        {
            text.text = Answer3;
        }

        else if(inputField.text == Input4)
        {
            text.text = Answer4;
        }

        else if(inputField.text == InputDG)
        {
            text.text = AnswerDG;
        }
    }
}
