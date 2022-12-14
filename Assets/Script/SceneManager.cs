using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void toScene02()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene02");
    }

    public void toScene03()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene03");
    }
}
