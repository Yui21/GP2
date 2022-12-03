using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon2 : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //左へパン
            //transform.Rotate(new Vector3(0, -0.5f, 0));
            transform.Rotate(0, -50 * Time.deltaTime, 0);   
        }

        if (Input.GetKey(KeyCode.S))
        {
            //右へパン
            transform.Rotate(0, 50 * Time.deltaTime, 0);
        }


        if (Input.GetKey(KeyCode.UpArrow) && transform.rotation.x == 0)
        {
            transform.position += transform.forward * Time.deltaTime * 1;
            //_animator.SetBool("isWalk", true);
        }
        
        
        if (Input.GetKey(KeyCode.DownArrow) && transform.rotation.x == 0)
        {
            transform.position -= transform.forward * Time.deltaTime * 1;
            //_animator.SetBool("isWalk", true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            _animator.SetBool("isWalk", true);
        }
        
    }
}
