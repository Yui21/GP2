using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class smartPhone : MonoBehaviour
{
    [SerializeField] GameObject smartPhoneButton;
    
    void OnDisable()
    {
        smartPhoneButton.SetActive(true);
    }
}
