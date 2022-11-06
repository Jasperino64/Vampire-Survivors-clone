using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x > 0) this.transform.Translate(1, 0, 0);
        if (x < 0) this.transform.Translate(-1, 0, 0);
        if (y > 0) this.transform.Translate(0, 1, 0);
        if (y < 0) this.transform.Translate(0, -1, 0);
    }
}
