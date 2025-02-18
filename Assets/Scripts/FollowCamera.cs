using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform Player;
    float offsetX;
    float offsetY;

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        { return; }

        offsetX = transform.position.x - Player.position.x;
        offsetY = transform.position.y - Player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        { return; }

        Vector3 pos = transform.position;
        pos.x = Player.position.x + offsetX;
        pos.y = Player.position.y + offsetY;



        transform.position = pos;
    }
}
