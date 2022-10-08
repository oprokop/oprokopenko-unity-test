using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public GameObject obj;
    private MeshRenderer meshRend;
   
    private void Start()
    {
        meshRend = obj.GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        meshRend.material.color = new Color(
          Random.Range(0f, 1f),
          Random.Range(0f, 1f),
          Random.Range(0f, 1f));
    }
}
