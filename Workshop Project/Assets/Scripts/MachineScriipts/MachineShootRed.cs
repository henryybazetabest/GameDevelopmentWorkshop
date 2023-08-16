
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineShootRed : MonoBehaviour
{
    public Transform firepoint;
    
    public Rigidbody2D bullet;
    
    public Transform target;
    public float range = 15f;
    public string enemyTag = "Enemy";

    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public GameObject bulletPrefab;
    public MachineHealth machineHealth;
    
    
   
   
    public GameObject GameManager;

    

    void Update()
    {
        GameManager = GameObject.FindGameObjectWithTag("gameManager");
    
    
        UpdateTarget();
       

        if (fireCountdown <= 0 && GameManager.GetComponent<WorldColour>().isRed)
        {
            
            Shoot();
            machineHealth.currentHP -= 1;
            



            fireCountdown = 1f / fireRate;
            
        }

        fireCountdown -= Time.deltaTime;
    }

    public void Shoot()
    {

        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firepoint.position, Quaternion.Euler(0, 0, 0));
        BulletVelocityScript bullet = bulletGO.GetComponent<BulletVelocityScript>();
        

        if (bullet != null)
        {
            bullet.Seek(target, enemyTag);
            
        }
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = Mathf.Infinity; ;

        GameObject nearestEnemy = null;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }

        }


        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
    }

    //void OnTriggerEnter2D(Collider2D collider) => _myName.enabled = true;
    //   void OnTriggerExit2D(Collider2D collider) => _myName.enabled = false;
}