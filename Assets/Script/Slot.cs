using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Mochimono mochimono;
    Image image;
    //[SerializeField] GameObject backgroundPanel = default;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    // private void Start()
    // {
    //     backgroundPanel.SetActive(false);
    // }

    public bool IsEmpty()
    {
        if(mochimono == null)
        {
            return true;
        }
        return false;
    }

    public void SetMochimono(Mochimono mochimono)
    {
        this.mochimono = mochimono;
        UpdateImage(mochimono);
    }

    //持ち物を受け取ったら、画像をスロットに表示
    void UpdateImage(Mochimono mochimono)
    {
        image.sprite = mochimono.sprite;
    }

    //選択した時の背景パネルを表示する関数　＝＞MochimonoBoxスクリプトのOnSelectSlot関数で使用
    // public bool OnSelected()
    // {
    //     if(mochimono == null) //　持ち物を持っていない場合
    //     {
    //         return false; //選択は失敗
    //     }

    //     backgroundPanel.SetActive(true); //背景画像パネルを表示する
    //     return true; //選択成功
    // }


    // //選択した時の背景パネルを消す関数　＝＞ItemBoxスクリプトのOnSelectSlot関数で使用
    // public void HideBgPanel()
    // {
    //     backgroundPanel.SetActive(false);
    // }
}
