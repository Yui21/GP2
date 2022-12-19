using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{
    // public GameObject ribe;
    // public Material ribe_magao;
    // public Material ribe_egao;

    [SerializeField] GameObject ribe_face;
    [SerializeField] Material[] ribes;

    float seconds;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //ribe_face.material = ribes[0];
    }

    void Update()
    {
        // if(seconds > 1)
        // {
        //     toRibeEgao();
        // }
              
    }

    public void toRibeEgao()
    {
        var ribe_face_mat = ribe_face.GetComponent<SkinnedMeshRenderer>();
        ribe_face_mat.material = ribes[1];
    }

    public void toRibeMagao()
    {
        var ribe_face_mat = ribe_face.GetComponent<SkinnedMeshRenderer>();
        ribe_face_mat.material = ribes[0];
    }
}
