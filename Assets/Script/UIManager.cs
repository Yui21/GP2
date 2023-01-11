using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject smartPhonePanel;
    //[SerializeField] GameObject transApp;
    [SerializeField] GameObject home;
    //[SerializeField] GameObject smartPhoneButton;

    public void OpenSmartPhonePanel()
    {
        smartPhonePanel.SetActive(true);
    }

    public void CloseSmartPhonePanel()
    {
        smartPhonePanel.SetActive(false);
    }

    public void OpenTransApp()
    {
        //ホーム画面のパネルを非表示にする＝TransAppを開く
        home.SetActive(false);
    }

    // public void CloseSmartPhonePanel()
    // {
    //     smartPhonePanel.SetActive(false);
    // }
    
    
}
