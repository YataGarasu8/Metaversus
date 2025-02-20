using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int addPoint = 0;
    public float runTime = 60f;

    private void Awake()
    {
        gameManager = this;
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UIManager.instance.UpdatePoint(addPoint);//���� ���� ���
        UIManager.instance.RunTime(runTime);
    }
}
