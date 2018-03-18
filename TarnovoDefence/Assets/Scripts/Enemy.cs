using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private int Dmg = 20;
    private int Health = 30;
    private float Speed = 10f;
    private Transform Target;
    private int WavepointIndex = 0;
    public void ModifyHealth(int Value)
    {
        if (Health - Value < 0)
        {
            Die();
        }
        else
        {
            Health += Value;
        }
    }
    private void Die()
    {
        PlayerStats.ModifyMoney(+50);
        Destroy(gameObject);
    }
    void Start()
    {
        Target = TheWay1.Points[0];
    }
    void Update()
    {
        Vector3 dir = Target.position - transform.position;
        transform.Translate(dir.normalized * Speed * Time.deltaTime, Space.World);
        if (Vector3.Distance(transform.position, Target.position) <= 0.4f)
        {
            GetNextPoint();
        }
    }
    void GetNextPoint()
    {
        if (WavepointIndex >= TheWay1.Points.Length - 1)
        {
            PlayerStats.ModifyHealth(-Dmg);
            Destroy(gameObject);
        }
        WavepointIndex++;
        Target = TheWay1.Points[WavepointIndex];
    }
}