using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnRoad1 : MonoBehaviour
{
    public GameObject road;
    private float roadLength = 20.5f;
    private int roadCounter;
    public int roadMaxCount;
    // Start is called before the first frame update
    void Start()
    {
        //roadLength = road.GetComponent<BoxCollider>().size.z;
    }

    // Update is called once per frame
    void Update()
    {
        roadCounter = GameObject.FindGameObjectsWithTag("Ground").Length;
        if(roadCounter <= roadMaxCount)
        {
            GenerateObject(road,roadCounter,roadLength);
        }
    }
    private void GenerateObject(GameObject prefab,int counter, float offset)
    {
        Vector3 position = prefab.transform.position + new Vector3(0,0,counter * offset);
        Instantiate(prefab,position,prefab.transform.rotation);
    }

    
}
    

