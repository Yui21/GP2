using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{
    //Elements0:真顔
    //Elements1:笑顔

    [SerializeField] GameObject face;
    [SerializeField] Material[] faces;

    // void Start()
    // {
    //     DontDestroyOnLoad(gameObject);
    // }

    public void toEgao()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[1];
    }

    public void toMagao()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[0];
    }
}
