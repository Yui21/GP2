using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager05to06 : MonoBehaviour
{
    private GameObject[] Item;

    void Update()
    {
        Item = GameObject.FindGameObjectsWithTag("Item");

        if(Item.Length == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene06");
        } 
    }
    
}
