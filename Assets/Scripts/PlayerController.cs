using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    public GameObject Fkey;
    protected override void ActionController()
    {
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
    private void OnCollisionEnter2D(Collision2D collision)//Collider에서 IsTrigger가 체크가 안되어 있을 때 사용, 매개변수 이름도 차이 남
    {
        if (collision.gameObject.CompareTag("Player")) // 충돌한 객체가 플레이어인지 확인
        {
            talkBox.SetActive(true);//플레이어가 범위에 있으면 대화 상자 출력 
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talkBox.SetActive(false); // 플레이어가 벗어나면 자동으로 대화 상자 숨기기
        }
    }
}
