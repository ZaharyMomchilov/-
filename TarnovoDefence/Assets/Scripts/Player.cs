using System.Collections;

using UnityEngine;

public class Player : MonoBehaviour {
    private Transform Target;
    [Header("Atributes")]
    private float Range = 15f;
    private float FireRate = 2f;
    private float FireCountdown = 0f;
    [Header("Settings")]
    public string EnemyTag = "Enemy";
    public Transform PartToRotate;
    public float TurnSpeed = 10f;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void UpdateTarget()
    {
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag(EnemyTag);
        float ShortestDistance = Mathf.Infinity;
        GameObject NearestEnemy = null;
        foreach (GameObject Enemy in Enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, Enemy.transform.position);
            if (distanceToEnemy < ShortestDistance)
            {
                ShortestDistance = distanceToEnemy;
                NearestEnemy = Enemy;
            }
        }
        if (NearestEnemy != null && ShortestDistance <= Range)
        {
            Target = NearestEnemy.transform;
        }
        else
        {
            Target = null;
        }
    }
    void Update()
    {
        if (Target == null)
        {
            return;
        }
        Vector3 dir = Target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        PartToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
        if (FireCountdown <= 0f)
        {
            Shoot();
            FireCountdown = 0.5f / FireRate;
        }
        FireCountdown -= Time.deltaTime;
    }
    void Shoot()
    {
        GameObject bulletGo = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        Bullet bullet = bulletGo.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.SetTarget(Target.GetComponent<Enemy>());
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
