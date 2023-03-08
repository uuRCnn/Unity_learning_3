using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_manger : MonoBehaviour
{
    [SerializeField] private Transform gun;
    [SerializeField] private GameObject mermiPrefabı;
    [SerializeField] private Transform mermiYeri;
    private float angle;
    private float donusHizi = 5f;

    void Update()
    {
        RotateDegistir();
    }

    void RotateDegistir()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - gun.transform.position;

            angle = MathF.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            MermiAt();
        }

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        gun.transform.rotation = Quaternion.Slerp(gun.transform.rotation, rotation, donusHizi * Time.deltaTime);
    }

    void MermiAt()
    {
        GameObject mermi = Instantiate(mermiPrefabı, mermiYeri.position, mermiYeri.rotation);
    }
}