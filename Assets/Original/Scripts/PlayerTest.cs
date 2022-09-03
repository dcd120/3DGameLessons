using System;
using SO.Events;
using UnityEngine;

public class PlayerTest : MonoBehaviour, IKillable
{
    [SerializeField] private IntVariable InitialHealth;
    [SerializeField] private IntVariable Health;
    //public  int PlayerHealth = 10;
    //[SerializeField]
    //private IntEventChannel helthChanged;

    private void Start()
    {
        Health.Value = InitialHealth.Value;
    }

    public void Kill()
    {

    }

    public void TakeDamage(int amount)
    {
        Health.Value -= amount;
        //helthChanged.RaiseEvent(Health.Value);

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public interface IKillable
{
    void Kill();
    //void Kill2();
}