using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
