using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graph : MonoBehaviour
{

    [SerializeField]
    Transform pointprefab;

    [SerializeField] int pow;

    [SerializeField,Range(10,100)] int resolution=10;
    Transform point;

    Transform[] points;

    private void Awake()
    {
        
        float step = 2f / resolution;

        var Scale = Vector3.one * step;

        Vector3 position=Vector3.zero;

        points = new Transform[resolution];

        for (int i=0; i < points.Length; i++) { 

        point = points[i] = Instantiate(pointprefab);

            

        position.x = ( ( i + 0.5f ) * step - 1 );




            point.localPosition = position;
            point.localScale = Scale;

            point.SetParent(transform,false);   
        }
    }

    private void Update()
    {
        float time = Time.time;
        for (int i = 0; i < points.Length; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y =  Mathf.Sin(Mathf.PI*(position.x+time)+1);
            point.localPosition = position;
            
        }
    }
}
