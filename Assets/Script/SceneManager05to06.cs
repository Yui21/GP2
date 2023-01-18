using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager05to06 : MonoBehaviour
{
    private GameObject[] Item;
    // private GameObject[] PictureBook;

    void Update()
    {
        Item = GameObject.FindGameObjectsWithTag("Item");
    //     PictureBook = GameObject.FindGameObjectsWithTag("PictureBook");

        
    
    }

    private void OnTriggerEnter(Collider other)
    //private void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.gameObject.CompareTag("Player") && Item.Length == 0)
        {
            // Debug.Log("Hit");
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene06");
        }
        //Debug.Log("Hit");
        
    }
    
}
