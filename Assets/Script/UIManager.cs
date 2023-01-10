using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject smartPhonePanel;
    //[SerializeField] GameObject smartPhone;
    //[SerializeField] GameObject smartPhoneButton;

    public void OpenSmartPhonePanel()
    {
        smartPhonePanel.SetActive(true);
    }

    public void CloseSmartPhonePanel()
    {
        smartPhonePanel.SetActive(false);
    }
    
    
}
