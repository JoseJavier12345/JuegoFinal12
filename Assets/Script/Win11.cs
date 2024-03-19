using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win11 : MonoBehaviour
{
    public void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            Debug.Log("Win");
            SceneManager.LoadScene("Win");
        }
    }

}
