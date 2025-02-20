using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public GameObject explainBord;

    public int addPoint = 0;
    public float runTime = 60f;
    int loop;

    private void Awake()
    {
        gameManager = this;
        //Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        UIManager.instance.UpdatePoint(addPoint);//게임 점수 출력
        UIManager.instance.RunTime(runTime);
    }
    public void GameStart()
    {
        if (loop == 1)
        {
            
        }
    }
    public void GameOver()
    { }
}
