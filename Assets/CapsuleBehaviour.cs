using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CapsuleBehaviour : MonoBehaviour
{
    public List<GameObject> objs;
    public GameObject currentObj;
    private MeshFilter meshFilter;
    private void Start()
    {
        meshFilter = currentObj.GetComponent<MeshFilter>();
    }

    void OnCollisionEnter(Collision collision)
    {

    }
}
