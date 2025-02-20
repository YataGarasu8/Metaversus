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
        transform.rotation = Quaternion.Euler(0, 0, 0);//���� �����ؼ� ��������Ʈ�� ���ư��� �� ����. �ٵ� ��մ� ���������� �߻�����
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
    private void OnTriggerEnter2D(Collider2D collision)//Collider���� IsTrigger�� üũ�� �ȵǾ� ���� �� ���, �Ű����� �̸��� ���� ��
    {
        if (collision.gameObject.CompareTag("NPC")) // �浹�� ��ü�� �÷��̾����� Ȯ��
        {
            Fkey.SetActive(true);//NPC�� ������ ������ Fǥ�� ��� 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NPC"))
        {
            Fkey.SetActive(false); // NPC�� ������ Fǥ�� �����
        }
    }
}
