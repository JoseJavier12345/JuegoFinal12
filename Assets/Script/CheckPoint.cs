using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider Collision)
    {
        if (Collision.CompareTag("Player"))
        {
            Collision.GetComponent<PlayerRes>().ReachedCheckPoint(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
