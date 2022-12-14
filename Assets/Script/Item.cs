using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] Mochimono.Type mochimonoType = default;
    Mochimono mochimono = default;
    [SerializeField] GameObject slot; // 対応するスロット

    public GameObject selected;

    private void Start()
    {
        //mochimonoTypeに応じてmochimonoを生成する
        mochimono = MochimonoGenerater.instance.Spawn(mochimonoType);
    }

    [Header("アイテムが拾われた時のイベント")]

    //インスペクターからも関数を触れるように
    public UnityEvent onPickUp;

    public void PickUp()
    {
        //UnityEventに登録されてる関数を実行
        onPickUp.Invoke();
        //消えた瞬間にMochimonoBoxに入れる（SetMochimono()を実行）
        //MochimonoBox.instance.SetMochimono(mochimono);       
        //持ち物リストの対応したスロットの画像がアクティブになる
        slot.SetActive(true);
        // 最後に自分を消す
        this.gameObject.SetActive(false);
    }
    
    
    //各持ち物が非アクティブになった時
    void OnDisable () 
    {
        Debug.Log(mochimonoType + "が非アクティブになった");

    }

    public void SelectedMochimono()
    {
        //スロットに画像が表示されていれば
        if(slot.activeSelf)
        {
            selected.SetActive(true);
            Debug.Log("クリック");
        }

        //Debug.Log("クリック");
    }
    
}