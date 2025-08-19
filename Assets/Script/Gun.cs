using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Gun : MonoBehaviour
{
    public static Action OnShoot;
    private Vector2 _mousePos;
    public Transform _bulletSpawnPoint;
    public float fireRate = 0.1f;
    [SerializeField] private Bullet _bulletPrefab;
    private float _lastFireTime = 0f;
    [SerializeField] private float _gunFireCD = .5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FireEffect(false);
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        RotateGun();
    }

    private void OnEnable()
    {
        OnShoot += ShootProjectile;
        OnShoot += ResetLastFireTime;
        ;
    }
    private void OnDisable()
    {
        OnShoot -= ShootProjectile;
        OnShoot -= ResetLastFireTime;
        ;
    }
    private void Shoot()
    {
        if (Input.GetMouseButton(0) && Time.time >= _lastFireTime)
        {
            OnShoot?.Invoke();

        }
    }

    private void ShootProjectile()
    {
        Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
    }

    private void ResetLastFireTime()
    {
        _lastFireTime = Time.time + _gunFireCD;
    }
    private void RotateGun() { 
        _mousePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
        Vector2 direction= PlayerController.instance.transform.InverseTransformDirection( _mousePos );
        float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
    private void FireEffect(bool spark)
    {
        //fireSpark.SetActive(spark);
    }
}
