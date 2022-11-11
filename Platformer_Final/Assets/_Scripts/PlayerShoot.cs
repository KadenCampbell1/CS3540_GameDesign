using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Camera mainCam;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    public float timeBetweenFiring;
    private float timer;
    private Vector3 mousePos;
    private void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotate = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotate.y, rotate.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(0,0,rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if (timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }
        if (Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }
}
