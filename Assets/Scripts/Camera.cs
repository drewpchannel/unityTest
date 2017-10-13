﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //Variables
    public Transform player;
    public float smooth = 0.3f;

    public float height;

    private Vector3 velocity = Vector3.zero;

    //Methods
    void Update()
    {
        UnityEngine.Camera.main.transform.rotation = Quaternion.Euler(new Vector3(50, 0, 0));
        Vector3 pos = new Vector3();
        pos.x = player.position.x;
        pos.z = player.position.z - 8f;
        pos.y = player.position.y + height;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }
}
