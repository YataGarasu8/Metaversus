using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemManager : MonoBehaviour
{
    Coroutine coroutine;

    [SerializeField] List<GameObject> sparkle;
    [SerializeField] List<GameObject> food;
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
}
