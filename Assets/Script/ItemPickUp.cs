using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private ItemSearch itemSearch;

    /// <summary>
    /// ItemPickUpにバインドされているボタンが押されたら呼ばれる
    /// </summary>
    public void OnItemPickUp()
    {
        var item = itemSearch.GetNearItem();
        if (item == null) return;
        item.GetComponent<Item>().PickUp();
    }
}