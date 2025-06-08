using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waktu
{
    private float lamanya;
}
public class LevelTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float waktu = 90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waktu > 0)
        {
            waktu -= Time.deltaTime;
        }
    }
}
