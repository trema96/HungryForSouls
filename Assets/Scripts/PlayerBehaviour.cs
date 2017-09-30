using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public GameObject bulletPrefab;
    public Camera mainCamera;
    public float shootTimer;

    private float shootTimerRunning;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Move
        float hMov = Input.GetAxis("Horizontal");
        float vMov = Input.GetAxis("Vertical");

        transform.Translate(hMov * speed * Time.deltaTime, 0, vMov * speed * Time.deltaTime, Space.World);

        //rotation
        var mouse_pos = Input.mousePosition;
        mouse_pos.z = 5.23f; //The distance between the camera and object
        var object_pos = mainCamera.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        var angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));

        //fire!
        if (Input.GetAxis("Fire1") != 0)
        {
            Fire();
        }

        //timers
        if (shootTimerRunning > 0)
        {
            shootTimerRunning -= Time.deltaTime;
        }
    }

    void Fire()
    {
        if (shootTimerRunning <= 0)
        {
            var bullet = Instantiate<GameObject>(bulletPrefab, transform.position, transform.rotation);
            Destroy(bullet, 2.0f);
            shootTimerRunning = shootTimer;
        }
    }
}
