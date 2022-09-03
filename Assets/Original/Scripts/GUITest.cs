using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITest : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private IntVariable InitialHealth;
    [SerializeField] private IntVariable Health;


    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 200, 140),"Super Hero");
        GUI.Label(new Rect(20, 40, 180, 30), $"Health: {Health.Value} / {InitialHealth.Value}");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
