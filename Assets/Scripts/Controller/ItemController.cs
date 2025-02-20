using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public AudioClip getCoinSound;

    public int point;
    public float time;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.addPoint += point;
            GameManager.instance.runTime += time;
            SoundManager.PlayClip(getCoinSound);
            Destroy(this.gameObject);
        }
    }
}
