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
            spriteRenderer.flipX = true;  // ���� �̵� �� ������
        }
        else if (horizontal < 0)
        {
            spriteRenderer.flipX = false; // ������ �̵� �� ���� ����
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//Collider���� IsTrigger�� üũ�� �ȵǾ� ���� �� ���, �Ű����� �̸��� ���� ��
    {
        if (collision.gameObject.CompareTag("Player")) // �浹�� ��ü�� �÷��̾����� Ȯ��
        {
            talkBox.SetActive(true);//�÷��̾ ������ ������ ��ȭ ���� ��� 
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talkBox.SetActive(false); // �÷��̾ ����� �ڵ����� ��ȭ ���� �����
        }
    }
}
