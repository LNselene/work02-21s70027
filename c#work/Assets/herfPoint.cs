using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class herfPoint : MonoBehaviour
{
    public Sprite tama;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D( Collider2D other ) {
        GameObject.Find( "Circle" ).GetComponent<SpriteRenderer>( ).enabled = false;
    }
}
