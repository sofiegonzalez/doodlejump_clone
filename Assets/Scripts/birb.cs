using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birb : MonoBehaviour
{
    public float speed = 10f;
    public float movement = 0f;
    public Text scoreText;

    private Rigidbody2D rb;

    public GameObject player;

    public static birb Instance{ get; private set; }

    public int jumps;

    // global var
    private void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + jumps.ToString();

    }

    void FixedUpdate(){
        // player movement with arrow keys
        movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);
    }
}
