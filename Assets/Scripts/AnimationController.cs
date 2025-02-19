using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private static readonly int PrMoving = Animator.StringToHash("PrMoving");

    protected Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move(Vector2 objec)
    {
        animator.SetBool(PrMoving, objec.magnitude > 0.5f);
    }
}
