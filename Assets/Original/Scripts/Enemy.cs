using System;
using SO.Events;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public int currentHelth = 10;
    public int damage = 2;
    public PlayerTest plyer;
    public IntVariable PlayerHealth;
    public IntEventChannel dealDamage;
    private void OnEnable()
    {
        //plyer = FindObjectOfType<PlayerTest>();
    }

    void TryDealDamage()
    {
        if (PlayerHealth.Value < 10)
        {
            int rand = Random.Range(0, 100);
            if (rand <= 50)
            {
                DealDamage(damage);
            }
        }
        else
        {
            DealDamage(damage);
        }
    }

    public void DealDamage(int damage)
    {
        dealDamage.RaiseEvent(damage);
        //plyer.TakeDamage(damage);
    }

}