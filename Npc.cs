using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    public Vector3 position;

    void Start()
    {
        health += level;
        print(health);
    }

    void Update()
    {
        position.z += speed * Time.deltaTime;
        transform.position = position;
    }
}