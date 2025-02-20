using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    public GameObject Fkey;

    //protected override void FixedUpdate()
    //{
        
    //}
    protected override void ActionController()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);//축을 고정해서 스프라이트가 돌아가는 걸 방지. 근데 재밌는 물리현상이 발생했음
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        moveValue = new Vector2(horizontal, vertical).normalized;

        if (horizontal > 0)
        {
            spriteRenderer.flipX = true;  // 왼쪽 이동 시 뒤집기
        }
        else if (horizontal < 0)
        {
            spriteRenderer.flipX = false; // 오른쪽 이동 시 원래 방향
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)//Collider에서 IsTrigger가 체크가 안되어 있을 때 사용, 매개변수 이름도 차이 남
    {
        if (collision.gameObject.CompareTag("NPC")) // 충돌한 객체가 플레이어인지 확인
        {
            Fkey.SetActive(true);//NPC가 범위에 있으면 F표시 출력 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Fkey.SetActive(false); // NPC가 없으면 F표시 숨기기
        }
    }
}
