using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Fogspawn : MonoBehaviour
{
    public GameObject projectilePrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }
    void spawn()
    {
        if (Input.GetKeyDown("f"))
        {
            Helper1.MakeBullet(projectilePrefab, transform.position.x + 0, transform.position.y + 10f, 5.0f, 0f);

        }

    }
}
