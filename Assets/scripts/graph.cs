using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graph : MonoBehaviour
{

    [SerializeField]
    Transform pointprefab;

    [SerializeField] int pow;

    [SerializeField,Range(10,100)] int resolution;

    Transform point;

    private void Awake()
    {
        int i=0;
        float step = 2f / resolution;
        
        var Scale = Vector3.one *step;

        Vector3 position=Vector3.zero;

        for (; i < resolution; i++) { 

        point = Instantiate(pointprefab);

        position.x = ((i+0.5f)*step-1);
            position.y =  Mathf.Sin(position.x*2f);

            

            point.localPosition = position;
            point.localScale = Scale;

            point.SetParent(transform,false);
            
        }

    }
}
