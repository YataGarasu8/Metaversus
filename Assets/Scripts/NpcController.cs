using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcController : MonoBehaviour
{
    public GameObject talkBox;
    // Start is called before the first frame update
    private void OnCollisionStay2D(Collision2D collision)
    {

        talkBox.gameObject.SetActive(true);
    }
}
