using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moveBall : MonoBehaviour
{
    
    Vector2 startPos;
    int rnd;
    public GameObject cube;
    private void Start( ) {
        rnd = Random.Range( 4, 10 );
    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    this.startPos = Input.mousePosition;
        //}
        //else if (Input.GetMouseButtonUp(0))
        //{
        //    Vector2 endPos = Input.mousePosition;
        //    float swipeLength = endPos.x - this.startPos.x;

        //    this.speed = swipeLength / 800.0f;


        //}

        //transform.Translate(this.speed, 0, 0);
        //this.speed *= 0.98f;
        cube.transform.position += new Vector3( rnd, 0, 0 ) * Time.deltaTime;
    }
    public void OnClick( ) 
    {
        rnd=0;
        GameObject.Find( "Circle" ).GetComponent<SpriteRenderer>( ).enabled = true;

    }

}
