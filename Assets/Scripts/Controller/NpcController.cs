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
    private void OnTriggerEnter2D(Collider2D collision)//Collider���� IsTrigger�� üũ �Ǿ� ���� �� ���
    {
        if (collision.gameObject.CompareTag("Player")) // �浹�� ��ü�� �÷��̾����� Ȯ��
        {
            trigger = true;
            talkBox.SetActive(true);//�÷��̾ ������ ������ ��ȭ ���� ��� 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            trigger = false;
            talkBox.SetActive(false); // �÷��̾ ����� �ڵ����� ��ȭ ���� �����
        }
    }

    //----����
    private void OnCollisionEnter2D(Collision2D collision)//Collider���� IsTrigger�� üũ�� �ȵǾ� ���� �� ���, �Ű����� �̸��� ���� ��
    {
        if (collision.gameObject.CompareTag("Player")) // �浹�� ��ü�� �÷��̾����� Ȯ��
        {
            talkBox.SetActive(true);//�÷��̾ ������ ������ ��ȭ ���� ��� 
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            talkBox.SetActive(false); // �÷��̾ ����� �ڵ����� ��ȭ ���� �����
        }
    }
}
