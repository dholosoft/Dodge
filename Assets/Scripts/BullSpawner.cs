using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullSpawner : MonoBehaviour
{
    public GameObject bullet;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3.0f;

    Transform target;
    float spawnRate;
    float timeAfterSpawn;

    // Start is called before the first frame update
    void Start() {
        timeAfterSpawn = 0;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update() {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= spawnRate) {
            GameObject newBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), transform.rotation);
            newBullet.transform.LookAt(target);
            timeAfterSpawn = 0;
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }
    }
}
