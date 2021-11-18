using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player1 : MonoBehaviour
{
    public float move_speed;
    public Rigidbody2D rig;
    public SpriteRenderer rend;


    Animator animate;

    private void Start()
    {

        animate = gameObject.GetComponent<Animator>();



    }


    void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal") * move_speed;



        float yInput = Input.GetAxis("Vertical") * move_speed;

        rig.velocity = new Vector2(xInput, yInput);

        //animation//

        animate.SetFloat("speed", Mathf.Abs(xInput    +    yInput)); 
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode)) 
    }

    
     */
    public void GameOver() 
    {
        SceneManager.LoadScene("StartScreen");
    }
}

