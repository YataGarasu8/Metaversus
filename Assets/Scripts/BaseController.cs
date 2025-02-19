using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    [SerializeField] SpriteRenderer spriteRenderer;

    protected Vector2 moveValue = Vector2.zero;
    protected Vector2 lookAt = Vector2.zero;
    protected Vector2 MoveValue { get { return moveValue; } }
    protected Vector2 LookAt { get { return lookAt; } }

    protected virtual void Awake()//virtual 적용하면 private를 못 쓰네.
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        ActionController();
        Rotate(lookAt);
    }
    protected virtual void FixedUpdate()
    {
        Movement(moveValue);
    }
    protected virtual void ActionController()
    { }
    void Movement(Vector2 value)
    {
        value = value * 5;

        rigidBody.velocity = value;
    }
    void Rotate(Vector2 value)
    {
        float rotZ = Mathf.Atan2(value.y, value.x) * Mathf.Rad2Deg;
        bool isRight = Mathf.Abs(rotZ) < 90f;

        spriteRenderer.flipX = isRight;
    }
}
