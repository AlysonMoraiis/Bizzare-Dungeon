using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRandomVein : MonoBehaviour
{
    [Header("Veins")]
    [SerializeField]
    private int veinAmount;
    [SerializeField]
    List<GameObject> veinsPrefabs;
    [SerializeField]
    List<Transform> veinsLocation;

    private int randomVeinIndex;
    private int veinsLocationIndex;
    void Start()
    {
        LoadVein();
    }

    private void LoadVein()
    {
        for(int i = 0; i < veinAmount; i++)
        {
            veinsLocationIndex = Random.Range(0, veinsLocation.Count);
            randomVeinIndex = Random.Range(0, veinsPrefabs.Count);
            Instantiate(veinsPrefabs[randomVeinIndex], veinsLocation[veinsLocationIndex]);
            veinsLocation.RemoveAt(veinsLocationIndex);
        }
    }
}
