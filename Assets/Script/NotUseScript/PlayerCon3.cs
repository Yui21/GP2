using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon3 : MonoBehaviour
{
  private enum catGirlState { STAND, WALK };

  private Animator animator;
  private catGirlState state;

  void Start()
  {
    animator = GetComponent<Animator>();
    //開始直後は「STAND」
    state = catGirlState.STAND;
  }

  void Update()
  {
    //上矢印が押されたら
    if (Input.GetKey("up")) {
      //全身
      transform.position += transform.forward * 0.04f;
      
      //「STAND」なら
      if (state == catGirlState.STAND) {
        //「WALK」に変更して歩くアニメーション再生
        state = catGirlState.WALK;
        animator.SetBool("isWalk", true);
      }
    }
    //上矢印が押されてないなら
    else {
      //「WALK」なら
      if (state == catGirlState.WALK) {
        //「STAND」に変更して停止アニメーション再生
        state = catGirlState.STAND;
        animator.SetBool("isWalk", false);
      }
    }

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
  }
}
