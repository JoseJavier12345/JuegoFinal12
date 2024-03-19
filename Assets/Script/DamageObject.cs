using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamegeObject : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("PlayerDamage");
            collision.transform.GetComponent<PlayerRes>().PlayerDamage();
        }
    }
}
