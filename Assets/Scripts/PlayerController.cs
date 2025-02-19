using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
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
}
