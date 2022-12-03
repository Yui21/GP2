using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochimonoBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    //[SerializeField] Slot selectedSlot = null;

    //SetMochimono()がどこでも実行できるようにする
    public static MochimonoBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            //staticにすればどこでも実行できる
            //どこでも実行できるやつに自分自身(this)を入れたら自分はどこでも使われるようになる
            instance = this;

            //slotsにslot要素をコードから入れる方法
            slots = GetComponentsInChildren<Slot>();
        }
    }
    //持ち物が消えたら（獲得されたら）、スロットに持ち物を入れる
    public void SetMochimono(Mochimono mochimono)
    {
        for(int i=0; i<slots.Length; i++)
        {
            if(slots[i].IsEmpty())
            {
                slots[i].SetMochimono(mochimono);
                break;
            }
        }
    }

    //スロットが選択された時に実行する関数
    // public void OnSelectSlot(int position)
    // {
    //     //一旦全てのスロットの選択パネルを非表示にする
    //     foreach(Slot slot in slots) //slotsの数だけ繰り返す
    //     {
    //         slot.HideBgPanel();
    //     }

    //     //選択されたスロットの選択パネルを表示する
    //     if (slots[position].OnSelected()) // もしアイテムの選択が成功したなら
    //     {
    //         selectedSlot = slots[position]; //選択しているスロットの番号を変数に入れる
    //     }
    // }
}
