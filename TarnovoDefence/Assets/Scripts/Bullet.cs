using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Enemy Target;
    private int Dmg = 10;
    private float Speed = 20f;
    public GameObject impactEffect;
    public void SetTarget(Enemy _Target)
    {
        Target = _Target;
    }

    void Update()
    {
        Vector3 dir = Target.transform.position - transform.position;
        float distanceThisFrame = Speed * Time.deltaTime;

        if (dir.magnitude <= 2f)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget() {
        Target.ModifyHealth(-Dmg);
        Destroy(gameObject);
    }
}
