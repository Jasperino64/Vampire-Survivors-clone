using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_camera_follows_player : MonoBehaviour
{
    public GameObject Target;
    public float CameraSpeed;
    public float MaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var camera_position = this.transform.position;
        var target_position = Target.transform.position;

        var direction = target_position - camera_position;
        if (direction.magnitude > MaxDistance)
        {
            var d = direction.normalized;
            var multiplier = direction.magnitude - (MaxDistance);
            d.Scale(new Vector3(multiplier, multiplier));
            transform.Translate(d);
        }
        else if (direction.magnitude > 1)
        {
            var d = direction.normalized;
            d.Scale(new Vector3(CameraSpeed, CameraSpeed, 0.0f));
            transform.Translate(d);
        }
            
    }
}
