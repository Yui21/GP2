using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentCard : MonoBehaviour
{
   public Dialog hint; //Dialogスクリプト
    public GameObject detail; //詳細画面に表示するアイテム
    //public GameObject studentCard;
    public GameObject bagDetailImage;

public void SelectedBag()
    {
        //赤枠がついていればクリックしたら詳細表示されて、赤枠ないけどアイテム画像がセットされているなら赤枠つける
        if(bagDetailImage.activeSelf)
        {
            hint.OpenDialog(detail);
        }
        // else if(slot.activeSelf)
        //     {
        //         GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
        //         foreach(GameObject select in selects)
        //         {
        //             select.SetActive(false);
        //         }
        //         selected.SetActive(true);
        //     }
    }
}
