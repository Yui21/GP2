using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{
    //Elements0:真顔
    //Elements1:笑顔
    //Elements2:驚き
    //Elements3:悲しみ

    [SerializeField] GameObject face;
    [SerializeField] Material[] faces;

    public void toMagao()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[0];
    }

    public void toEgao()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[1];
    }

    public void toOdoroki()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[2];
    }

    public void toKanashimi()
    {
        var face_mat = face.GetComponent<SkinnedMeshRenderer>();
        face_mat.material = faces[3];
    }
}
