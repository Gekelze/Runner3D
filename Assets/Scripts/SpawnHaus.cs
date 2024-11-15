
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHaus : MonoBehaviour
{
    public GameObject[] hausPrefab;
    public Vector3 pos;
    public int indexRandom;
    // Start is called before the first frame update
    void Start()
    {
      //  InvokeRepeating("SpawnHause",0,1);
    }

    // Update is called once per frame
   // private void SpawnHause()
   // {
      //  indexRandom = Random.Range(0,hausPrefab.Length);
     //   pos = new Vector3(0,0,115);
     //   Instantiate(hausPrefab[indexRandom],pos,hausPrefab[indexRandom].transform.rotation);
    }
//}
