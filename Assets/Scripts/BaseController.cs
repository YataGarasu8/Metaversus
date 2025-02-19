using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D rigidBody;

    [SerializeField] public SpriteRenderer spriteRenderer;

    protected Vector2 moveValue = Vector2.zero;
    protected Vector2 lookAt = Vector2.zero;
    protected Vector2 MoveValue { get { return moveValue; } }
    protected Vector2 LookAt { get { return lookAt; } }

    protected AnimationController animationController;
    protected virtual void Awake()//virtual 적용하면 private를 못 쓰네.
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animationController = GetComponent<AnimationController>();
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        ActionController();
        Rotate(LookAt);
    }
    protected virtual void FixedUpdate()
    {
        Movement(MoveValue);
    }
    protected virtual void ActionController()
    { }
    void Movement(Vector2 value)
    {
        value = value * 5;
        rigidBody.velocity = value;
        animationController.Move(value);
    }
    void Rotate(Vector2 value)
    {
        
    }
}
