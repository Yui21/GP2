using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibeMotion : MonoBehaviour
{
    public float nowPosi;

    void Start () {
        nowPosi = this.transform.position.y;
    }

    void Update () {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time/15, 0.05f), transform.position.z);
    }
}
