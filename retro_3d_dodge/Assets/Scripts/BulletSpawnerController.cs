using UnityEngine;

public class BulletSpawnerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 2f;
    public float spawnRateMax = 6f;

    Transform target;
    float spawnRate;
    float timeAfterSpawn;

    void Start()
    {
        timeAfterSpawn = 0;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindAnyObjectByType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if(timeAfterSpawn >= spawnRate)
        {            
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            timeAfterSpawn = 0;
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
