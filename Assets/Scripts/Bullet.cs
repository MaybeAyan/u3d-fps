using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    public float lifeTime = 2;

    float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        transform.position += speed * transform.forward * Time.deltaTime;

        if (startTime + lifeTime < Time.time)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
