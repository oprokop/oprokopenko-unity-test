using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public List<GameObject> objs;
    public float speed;
    private GameObject spawnedObj;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnedObj = Instantiate(objs[Random.Range(0, objs.Count)], transform.position, transform.rotation);
            spawnedObj.GetComponent<Rigidbody>().velocity = Vector3.forward * speed * Time.fixedDeltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnedObj.GetComponent<Rigidbody>().AddForce(Vector3.back);
    }
}
