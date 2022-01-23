using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObjectPrefabs;
    public int ObjectIndex;
    private float SpawnRangeX ;
    private float SpawnPosZ = -100;
    private float RepeatTime = 5;
    private float DelayTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandonObjects",DelayTime,RepeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnRandonObjects()
    {
        //SpawnRangeX = Random.Range(-85, 85);
        //ObjectIndex = Random.Range(0, ObjectPrefabs.Length);
        //Instantiate(ObjectPrefabs[ObjectIndex], new Vector3(SpawnRangeX, 0.7f, SpawnPosZ), ObjectPrefabs[ObjectIndex].transform.rotation);

        //for (int i = 0; i < ObjectPrefabs.Length; i++)
        //{
        //    ObjectIndex = i;
        //    Instantiate(ObjectPrefabs[ObjectIndex], new Vector3(SpawnRangeX, 0.7f, SpawnPosZ), ObjectPrefabs[ObjectIndex].transform.rotation);
        //    SpawnRangeX -= 30;
        //}
        Instantiate(ObjectPrefabs[0], new Vector3(80, 0.7f, SpawnPosZ), ObjectPrefabs[0].transform.rotation);
        Instantiate(ObjectPrefabs[1], new Vector3(50, 0.7f, SpawnPosZ), ObjectPrefabs[1].transform.rotation);
        Instantiate(ObjectPrefabs[2], new Vector3(20, 0.7f, SpawnPosZ), ObjectPrefabs[2].transform.rotation);
        Instantiate(ObjectPrefabs[3], new Vector3(-10, 0.7f, SpawnPosZ), ObjectPrefabs[3].transform.rotation);
        Instantiate(ObjectPrefabs[4], new Vector3(-40, 0.7f, SpawnPosZ), ObjectPrefabs[4].transform.rotation);
        Instantiate(ObjectPrefabs[5], new Vector3(-70, 0.7f, SpawnPosZ), ObjectPrefabs[5].transform.rotation);
        Instantiate(ObjectPrefabs[6], new Vector3(-100, 0.7f, SpawnPosZ), ObjectPrefabs[6].transform.rotation);
    }
}
