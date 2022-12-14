using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject dialog;
    private GameObject current;

    public void OpenDialog(GameObject detail)
    {
        current = detail;
        ChangeActive(true);
    }

    public void CloseDialog()
    {
        ChangeActive(false);
    }

    private void ChangeActive(bool active)
    {
        dialog.SetActive(active);
        current.SetActive(active);
    }
}
