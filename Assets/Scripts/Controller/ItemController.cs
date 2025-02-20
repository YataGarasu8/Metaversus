using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int point;
    public float time;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.gameManager.addPoint += point;
            GameManager.gameManager.runTime += time;
            Destroy(this.gameObject);
        }
    }
}
