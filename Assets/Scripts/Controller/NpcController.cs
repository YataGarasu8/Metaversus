using UnityEngine;

public class NpcController : MonoBehaviour
{
    public GameObject talkBox;
    public int roadCode;

    bool trigger = false;

    private void Start()
    {

    }
    private void Update()
    {
        if (trigger == true && Input.GetKeyDown(KeyCode.F))
        {
            if (roadCode == 0)
            { UIManager.instance.OnClickExit(); }
            else if (roadCode == 1)
            { UIManager.instance.OnClickStart(); }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)//Collider에서 IsTrigger가 체크 되어 있을 때 사용
    {
        if (collision.gameObject.CompareTag("Player")) // 충돌한 객체가 플레이어인지 확인
        {
            trigger = true;
            talkBox.SetActive(true);//플레이어가 범위에 있으면 대화 상자 출력 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            trigger = false;
            talkBox.SetActive(false); // 플레이어가 벗어나면 자동으로 대화 상자 숨기기
        }
    }

    //----더미
    private void OnCollisionEnter2D(Collision2D collision)//Collider에서 IsTrigger가 체크가 안되어 있을 때 사용, 매개변수 이름도 차이 남
    {
        if (collision.gameObject.CompareTag("Player")) // 충돌한 객체가 플레이어인지 확인
        {
            talkBox.SetActive(true);//플레이어가 범위에 있으면 대화 상자 출력 
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talkBox.SetActive(false); // 플레이어가 벗어나면 자동으로 대화 상자 숨기기
        }
    }
}
