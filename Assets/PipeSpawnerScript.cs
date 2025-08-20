using UnityEngine;
using UnityEngine.Timeline;
public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float SpawnRate;
    private float timer = 0;
    public float highest0ffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - highest0ffset;
        float highestPoint = transform.position.y + highest0ffset;
         
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
    }


}
