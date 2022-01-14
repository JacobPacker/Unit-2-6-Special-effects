using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FogSpawn : MonoBehaviour
{
    public GameObject projectilePrefab;
    private Rigidbody2D rb;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spawn();
    }
    void spawn()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0;


        if (Input.GetKeyDown("f"))
        {
            Helper1.MakeBullet(projectilePrefab, transform.position.x + 0, transform.position.y + 0.65f, -1f, 0f);
            velocity.x = -2;

        }

    }
}
