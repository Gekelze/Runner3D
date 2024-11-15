using UnityEngine;
public class SpawnObstacles : MonoBehaviour
{
  public GameObject[] obstacles;
  private int indexObstacles;
  public float posZ;
  void Start()
  {
    InvokeRepeating("SpawnObstacle",1,1);
  }
  private void SpawnObstacle()
  {          
    Vector3 pos = new Vector3(0,0,posZ);
    indexObstacles = Random.Range(0,obstacles.Length);
    Instantiate(obstacles[indexObstacles],pos,obstacles[indexObstacles].transform.rotation);     
  }
}
