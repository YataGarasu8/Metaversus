using UnityEngine;

public class NpcController : MonoBehaviour
{ 
    public GameObject talkBox;

    private void Start()
    {

    }
    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//Collider���� IsTrigger�� üũ �Ǿ� ���� �� ���
    {
        if (collision.gameObject.CompareTag("Player")) // �浹�� ��ü�� �÷��̾����� Ȯ��
        {
            talkBox.SetActive(true);//�÷��̾ ������ ������ ��ȭ ���� ��� 
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
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
