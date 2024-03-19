using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRes : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY, checkPointPositionZ;
       void Start()
    {
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position= (new Vector3(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY"), PlayerPrefs.GetFloat("checkPointPositionZ")));
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReachedCheckPoint(float x, float y, float z)
    {
        PlayerPrefs.SetFloat("checkPointPositionX", x);
       PlayerPrefs.SetFloat("checkPointPositionY", y);
       PlayerPrefs.SetFloat("checkPointPositionZ", z);
    }

    public void PlayerDamage()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
