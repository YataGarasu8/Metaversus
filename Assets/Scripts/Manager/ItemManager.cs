using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemManager : MonoBehaviour
{
    Coroutine coroutine;

    [SerializeField] List<GameObject> sparkleprefab;
    [SerializeField] List<Rect> spawnAreas;
    [SerializeField] float timeBetweenSpawnsCoin = 0.2f;
    [SerializeField] float timeBetweenSpawnsFood = 1f;

    bool spawnComplite;

    public void Startwave()
    {
        
    }
    public void Stopwave()
    {

    }
    void SpawnItem()
    {
        GameObject randomPrefab = sparkleprefab[Random.Range(0, sparkleprefab.Count)]; //리스트 내의 랜덤한 아이템 생성
        Rect randomArea = spawnAreas[Random.Range(0, spawnAreas.Count)]; //아이탬을 생성할 랜덤 영역 설정
    }
}
