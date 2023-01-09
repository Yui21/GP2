using System;
using UnityEngine;

[Serializable]
public class Mochimono
{
    //アイテムの種類を列挙する
    //enumは列挙型
    public enum Type
    {
        Bag,
        Phone,
        Paints,
        Art,
        Jiyuuchou,
        Syoujyou,
        PictureBook,
    }
    
    //持ち物の種類
    public Type type;

    //持ち物のスロットに表示する用の画像
    public Sprite sprite;

    //持ち物の詳細を大きく表示する用の画像
    public Sprite detailSprite;

    public Mochimono(Type type, Sprite sprite, Sprite detailSprite)
    {
        this.type = type;
        this.sprite = sprite;
        this.sprite = detailSprite;
    }
}
