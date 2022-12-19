using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{
    // public GameObject ribe;
    // public Material ribe_magao;
    // public Material ribe_egao;

    [SerializeField] MeshRenderer ribe_face;
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
        ribe_face.material = ribes[1];
        Debug.Log("smile");
    }

    public void toRibeMagao()
    {
        ribe_face.material = ribes[0];
    }
}
