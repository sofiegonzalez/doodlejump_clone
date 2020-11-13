using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;
    public GameObject spring;
    private GameObject myPlat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){

        // improved spacing
        if(collision.gameObject.name.StartsWith("platform")){
            if(Random.Range(1,7) == 1){
                Destroy(collision.gameObject);
                Instantiate(spring, new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f))), Quaternion.identity);
            }else{
                collision.gameObject.transform.position =  new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f)));
            }
        }else if(collision.gameObject.name.StartsWith("spring")){
            if(Random.Range(1,7) == 1){
                collision.gameObject.transform.position =  new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f)));
            }else{
                Destroy(collision.gameObject);
                Instantiate(platform, new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f))), Quaternion.identity);
            }
        }
        // old
        // // normal plat
        // if(Random.Range(1,6) > 1){
        //     myPlat = (GameObject)Instantiate(platform, new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f))), Quaternion.identity);
        // }else{
        //     myPlat = (GameObject)Instantiate(spring, new Vector2(Random.Range(-4f,4f),player.transform.position.y + (14 + Random.Range(0.5f,1f))), Quaternion.identity);
        // }
        
        // Destroy(collision.gameObject);
    }
}
