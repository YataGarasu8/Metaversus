using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public ItemManager itemManager;

    public GameObject explainBoard;
    public GameObject endPanel;

    public int addPoint;
    public float runTime;
    int loop;

    private void Awake()
    {
        instance = this;
        explainBoard.SetActive(false);
        Time.timeScale = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        endPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();
        UIManager.instance.UpdatePoint(addPoint);//게임 점수 출력
        UIManager.instance.RunTime(runTime);
    }
    public void GameStart()
    {
        if (loop != 1)
        {
            explainBoard.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                loop = 1;
                explainBoard.SetActive(false);
                Time.timeScale = 1f;
            }
        }
        else
        {
            explainBoard.SetActive(false);
            Time.timeScale = 1f;
        }

    }
    public void GameOver()
    {

        itemManager.StopWave();//싱글톤도 new를 해도 null이었던 놈... 대체 왜?
        endPanel.SetActive(true);
        Time.timeScale = 0f;
        RetrunOrMain();
    }
    public void RetrunOrMain()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { UIManager.instance.OnClickReturn(); }
        else if (Input.GetKeyDown(KeyCode.F))
        { UIManager.instance.OnClickStart(); }

    }
}
