using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pink_enemy : MonoBehaviour
{
    // who we want to chase
    public GameObject Target;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.speed == 0) return;
        
        var direction = Target.transform.position - transform.position;
        if (System.Math.Abs(direction.magnitude) < 1)
        {
            this.speed = 0;
            // TODO: we've caught the player! 
            // Do something cool. For now, we'll just turn red and die :(
            this.GetComponent<SpriteRenderer>().color = Color.red;
            DieSoon();
        } else {
            // keep chasing
            direction.Normalize();
            direction.x *= speed; direction.y *= speed;
            transform.Translate(direction);
        }
    }
    IEnumerable DieSoon()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
