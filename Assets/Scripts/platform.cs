using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public int jumps = 0;

    void Start(){

    }

    void Update(){

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0){
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
            birb.Instance.jumps += 1;
        }
    }
}
 