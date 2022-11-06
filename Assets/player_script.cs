using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public float PlayerSpeed;
    public Sprite sprite1;
    public Sprite sprite2;

    private int loop_counter = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() 
    {
        // move based on WASD input.
        // For some reason this seems more snappy than using Input.GetAxis
        float x_speed = 
            Input.GetKey(KeyCode.D) ? PlayerSpeed :
            Input.GetKey(KeyCode.A) ? -PlayerSpeed : 0;
        float y_speed = 
            Input.GetKey(KeyCode.W) ? PlayerSpeed:
            Input.GetKey(KeyCode.S) ? -PlayerSpeed : 0;
        this.transform.Translate(x_speed, y_speed, 0);

        // while we're moving, change the sprites
        bool is_moving = x_speed != 0 || y_speed != 0;
        if (is_moving)
        {
            var renderer = this.GetComponent<SpriteRenderer>();
            renderer.sprite = (loop_counter++ / 10) % 2 == 0 ? sprite1 : sprite2;
        }
    }
}
