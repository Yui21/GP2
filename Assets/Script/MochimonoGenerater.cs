using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochimonoGenerater : MonoBehaviour
{
    // [SerializeField] MochimonoListEntity mochimonoListEntity = default;

    // public static MochimonoGenerater instance;
    // private void Awake()
    // {
    //     if(instance == null)
    //     {
    //         //staticにすればどこでも実行できる
    //         //どこでも実行できるやつに自分自身(this)を入れたら自分はどこでも使われるようになる
    //         instance = this;
    //     }
    // }

    // public Mochimono Spawn(Mochimono.Type type)
    // {
    //     //mochimonoListの中からtypeと一致するmochimonoを生成して渡す
    //     foreach (Mochimono mochimono in mochimonoListEntity.mochimonoList)
    //     {
    //         if(mochimono.type == type)
    //         {
    //             return new Mochimono(mochimono.type, mochimono.sprite, mochimono.detailSprite);
    //         }
    //     }
    //     return null;
    // }
}
