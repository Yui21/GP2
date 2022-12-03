// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using UnityEngine;

// public class ItemSearch : MonoBehaviour
// {
//     [SerializeField, Header("アイテムを取得する原点(これを元に近いアイテム、遠いアイテムが決まる)")] private GameObject originPoint;

//     public List<GameObject> ItemList { get; private set; } = new List<GameObject>();

//     [Header("アイテムリストを常に更新")]
//     //初期状態というか常に更新されてるという設定
//     public bool isAlwaysUpdate = true;

//     //アイテムリストが更新されたか
//     private bool isItemListUpdate;

//     private void Start()
//     {
//         //アイテム削除関数を実行開始(時差で)
//         StartCoroutine(LateFixedUpdate());
//     }

//     //オブジェクトと触れた時の呼ばれる関数
//     private void OnTriggerEnter(Collider other)
//     {
//         //そのオブジェクトのタグがItemなら
//         if(other.CompareTag("Item"))
//         {
//             //アイテムリスト更新
//             isItemListUpdate == true;
//             var item = other.GetComponent<Item>();

//             //アイテムを拾った時アイテムリストから除外するイベントを登録
//             item.onPickUp.AddListener(() => ItemList.Remove(other.gameObject));
//             item.onPickUp.AddListener(() => isItemListUpdate = true);
//             ItemList.Add(other.gameObject);
//         }
//     }

//     //オブジェクトから離れた時呼ばれる関数
//     private void OnTriggerExit(Collider other)
//     {
//         //そのオブジェクトのタグがItemなら
//         if(other.CompareTag("Item"))
//         {
//             isItemListUpdate == true;
//             ItemList.Remove(other.gameObject);
//         }
//     }

//     //FixedUpdateの実行タイミングで一番最後に実行される関数
//     private IEnumerator LateFixedUpdate()
//     {
//         var WaitForFixed = new WaitForFixed();
//         while(true)
//         {
//             //常に更新フラグが立っているか、アイテムリストが更新された時だけ要素の入れ替えを実行
//             if(isAlwaysUpdate || isItemListUpdate)
//             {
//                 pickUpNearItemFirst();
//                 isItemListUpdate == false;
//             }
//             yield return waitForFixed;
//         }
//     }

//     //一番近場のアイテムを先頭に持ってくる
//     private void PickUpNearItemFirst()
//     {
//         //SearchErea内のアイテムが1個以下ならここの関数には入ってくる必要がない(近くに1アイテムしか無かったら一番近場とかないから)
//         if(ItemList.Count <= 1) return;

//         var originPos = originPoint.transform.position;
//         //距離の初期最小値を設定
//         var minDirection = Vector3.Distance(ItemList[0].transform.position, originPos);

//         //2つ目のアイテムから取得ポイントとの距離を計算
//         //アイテム数2からアイテム数がエリア内の全てのアイテム数に到達するまで繰り返す
//         for(int itemNum = 1; itemNum < ItemList.Count; itemNum++)
//         {
//             var direction = Vector3.Distance(ItemList[itemNum].transform.position, originPos);

//             //より近いアイテムを0番目の要素に代入
//             //minDirectionより小さかったらその距離をminDirectionにする
//             if(minDirection > distance)
//             {
//                 minDirection = direction;
//                 var temp = ItemList[0];
//                 ItemList[0] = ItemList[itemNum];
//                 ItemList[itemNum] = temp;
//             }
//         }
//     }

//     //一番近いイアテムを返す
//     public GameObject GetNearItem()
//     {
//         //エリア内にアイテムが無いなら
//         if(ItemList.Count <= 0) return null;

//         return ItemList[0];
//     }

//     #if UNITY_EDITOR // UnityEditorのみ
//     /// <summary>
//     /// 拾う対象のアイテムにギズモを表示
//     /// </summary>
//     private void SetPickUpTargetItemMarker()
//     {
//         var item = GetNearItem();
//         if (item == null) return;
//         Gizmos.DrawSphere(item.transform.position, 0.1f);
//     }
//     private void OnDrawGizmos()
//     {
//         SetPickUpTargetItemMarker();
//     }
// #endif
// }


using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ItemSearch : MonoBehaviour
{
    [SerializeField, Header("アイテムを取得する原点(これを元に近いアイテム、遠いアイテムが決まる)")] private GameObject originPoint;

    public List<GameObject> ItemList { get; private set; } = new List<GameObject>();

    [Header("アイテムリストを常に更新")]
    public bool isAlwaysUpdate = true;
    // アイテムリストが更新されたか
    private bool isItemListUpdate;

    private void Start()
    {
        // アイテム削除関数を実行開始
        StartCoroutine(LateFixedUpdate());
    }

    /// <summary>
    /// オブジェクトと接触した時呼ばれる
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            isItemListUpdate = true;
            var item = other.GetComponent<Item>();
            // アイテムを拾った時アイテムリストから除外するイベントを登録
            item.onPickUp.AddListener(() => ItemList.Remove(other.gameObject));
            item.onPickUp.AddListener(() => isItemListUpdate = true);
            ItemList.Add(other.gameObject);
        }
    }

    /// <summary>
    /// オブジェクトが離れた時呼ばれる
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            isItemListUpdate = true;
            ItemList.Remove(other.gameObject);
        }
    }

    /// <summary>
    /// FixedUpdateの実行タイミングで一番最後に実行される関数
    /// </summary>
    /// <returns></returns>
    private IEnumerator LateFixedUpdate()
    {
        var waitForFixed = new WaitForFixedUpdate();
        while (true)
        {
            // 常に更新フラグが立っているか、アイテムリストが更新された時だけ要素の入れ替えを実行
            if (isAlwaysUpdate || isItemListUpdate)
            {
                PickUpNearItemFirst();
                isItemListUpdate = false;
            }
            yield return waitForFixed;
        }
    }

    /// <summary>
    /// 一番近場のアイテムを配列の先頭に持ってくる
    /// </summary>
    /// <returns></returns>
    private void PickUpNearItemFirst()
    {
        if (ItemList.Count <= 1) return;

        var originPos = originPoint.transform.position;
        // 初期最小値を設定
        var minDirection = Vector3.Distance(ItemList[0].transform.position, originPos);
        // 二つ目のアイテムから取得ポイントとの距離を計算
        for (int itemNum = 1; itemNum < ItemList.Count; itemNum++)
        {
            var direction = Vector3.Distance(ItemList[itemNum].transform.position, originPos);
            // より近いオブジェクトを0番目の要素に代入
            if (minDirection > direction)
            {
                minDirection = direction;
                var temp = ItemList[0];
                ItemList[0] = ItemList[itemNum];
                ItemList[itemNum] = temp;
            }
        }
    }

    /// <summary>
    /// 一番近いアイテムを返す
    /// </summary>
    /// <returns></returns>
    public GameObject GetNearItem()
    {
        if (ItemList.Count <= 0) return null;

        return ItemList[0];
    }

#if UNITY_EDITOR // UnityEditorのみ
    /// <summary>
    /// 拾う対象のアイテムにギズモを表示
    /// </summary>
    private void SetPickUpTargetItemMarker()
    {
        var item = GetNearItem();
        if (item == null) return;
        Gizmos.DrawSphere(item.transform.position, 0.1f);
    }
    private void OnDrawGizmos()
    {
        SetPickUpTargetItemMarker();
    }
#endif
}