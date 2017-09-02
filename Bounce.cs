using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounce : MonoBehaviour {

    public float speedx;
    public float speedy;
    public GameObject pad1;
    public GameObject pad2;
    private int scoreA;
    private int scoreB;
    public Text scorea;
    public Text scoreb;
  
    void Update () {

        transform.Translate(new Vector3(speedx, speedy, 0)*Time.deltaTime);
        if (transform.position.x > 8.5)
        {
            scoreB = scoreB +1;
            Debug.Log(scorea.text = " " + scoreA.ToString());
            transform.position = new Vector3(0, 0, 0);
        }
        if (transform.position.x < -8.5)
        {
            scoreA = scoreA +1;
            Debug.Log(scoreb.text = " " + scoreB.ToString());
            transform.position = new Vector3(0, 0, 0);
        }

        if (transform.position.y>Camera.main.orthographicSize || -transform.position.y > Camera.main.orthographicSize)
        {
            speedy *= -1;
        }
       
        if (transform.position.x > pad2.transform.position.x-0.41 && transform.position.y <= pad2.transform.position.y+1.5 && transform.position.y>=pad2.transform.position.y-1.5)
        {
            speedx = -speedx;
        }
        if(transform.position.x < pad1.transform.position.x + 0.41 && transform.position.y <= pad1.transform.position.y + 1.5 && transform.position.y >= pad1.transform.position.y - 1.5)
        {
            speedx = -speedx;
        }
        
        
    }
    

}
