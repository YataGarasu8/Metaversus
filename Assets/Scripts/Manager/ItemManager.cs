using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemManager : MonoBehaviour
{
    Coroutine waveRoutine;

    [SerializeField] List<GameObject> sparkleprefab;
    [SerializeField] List<Rect> spawnAreas;
    [SerializeField] float timeBetweenSpawnsCoin = 0.2f;
    [SerializeField] private Color gizmoColor = new Color(1, 0, 0, 0.3f); // 기즈모 색상

    List<ItemController> activeItem = new List<ItemController>();
    //bool spawnComplite;

    public void StartWave()
    {
        if (waveRoutine != null)
        { StopCoroutine(waveRoutine); }
        waveRoutine = StartCoroutine(SpawnWave(2));
    }
    public void StopWave()
    {
        StopAllCoroutines();
    }
    private IEnumerator SpawnWave(int waveCount)
    {
        //spawnComplite = false;
        yield return new WaitForSeconds(timeBetweenSpawnsCoin);
        for (int i = 0; i < waveCount; i++)
        {
            yield return new WaitForSeconds(timeBetweenSpawnsCoin);
            SpawnRandomItem();
        }

        //spawnComplite = true;
    }
        void SpawnRandomItem()
    {
        GameObject randomPrefab = sparkleprefab[Random.Range(0, sparkleprefab.Count)]; //리스트 내의 랜덤한 아이템 선택
        Rect randomArea = spawnAreas[Random.Range(0, spawnAreas.Count)]; //아이탬을 생성할 랜덤 영역 선택
        Vector2 randomPosition = new Vector2(
            Random.Range(randomArea.xMin, randomArea.xMax),
            Random.Range(randomArea.yMin, randomArea.yMax));//영역 내의 생성 위치 계산

        GameObject spawnItem = Instantiate(randomPrefab, new Vector3(randomPosition.x, randomPosition.y), Quaternion.identity);
        ItemController itemController = spawnItem.GetComponent<ItemController>();

        activeItem.Add(itemController);
    }
    private void OnDrawGizmosSelected()//지정할 영역(Rect)을 시각화 해서 볼수 있음  
    {
        if (spawnAreas == null) return;

        Gizmos.color = gizmoColor;
        foreach (var area in spawnAreas)
        {
            Vector3 center = new Vector3(area.x + area.width / 2, area.y + area.height / 2);
            Vector3 size = new Vector3(area.width, area.height);
            Gizmos.DrawCube(center, size);
        }
    }
    private void Start()
    {
        InvokeRepeating("StartWave", 1f, 3f); 
    }
}
