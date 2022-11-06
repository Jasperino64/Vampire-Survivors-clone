using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public float PlayerSpeed { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        PlayerSpeed = 0.3f;
    }

    // Update is called once per frame
    void Update() 
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.D)) this.transform.Translate(PlayerSpeed, 0, 0);
        if (Input.GetKey(KeyCode.A)) this.transform.Translate(-PlayerSpeed, 0, 0);
        if (Input.GetKey(KeyCode.W)) this.transform.Translate(0, PlayerSpeed, 0);
        if (Input.GetKey(KeyCode.S)) this.transform.Translate(0, -PlayerSpeed, 0);
    }
}
