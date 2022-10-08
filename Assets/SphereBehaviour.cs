using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
