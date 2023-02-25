using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement1 : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public float p1speed;
    public float p2speed;
    public Transform directionplayer1;
    public Transform directionplayer2;
    Vector3 directionp1, directionp2;


    void Start()
    {
        directionp2 = directionp1 = Vector3.zero;
    }

    
    void Update()
    {
        directionp2 = directionp2.normalized * .01f;
        directionp1 = directionp1.normalized * .01f;


        if (player1 != null && player2 != null)
        {
            if (Input.GetKey(KeyCode.W))
            {
                player1.transform.position += new Vector3(0, 0, +p1speed) * Time.deltaTime;
                directionp1 += new Vector3(0, 0, +p1speed);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player2.transform.position += new Vector3(0, 0, +p2speed) * Time.deltaTime;
                directionp2 += new Vector3(0, 0, +p2speed);
            }
          

            if (Input.GetKey(KeyCode.S))
            {
                player1.transform.position += new Vector3(0, 0, -p1speed) * Time.deltaTime;
                directionp1 += new Vector3(0, 0, -p1speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                player2.transform.position += new Vector3(0, 0, -p2speed) * Time.deltaTime;
                directionp2 += new Vector3(0, 0, -p2speed);
            }
        

            if (Input.GetKey(KeyCode.A))
            {
                player1.transform.position += new Vector3(-p1speed, 0, 0) * Time.deltaTime;
                directionp1 += new Vector3(-p1speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player2.transform.position += new Vector3(-p2speed, 0, 0) * Time.deltaTime;
                directionp2 += new Vector3(-p2speed, 0, 0);
            }


            if (Input.GetKey(KeyCode.D))
            {
                player1.transform.position += new Vector3(+p1speed, 0, 0) * Time.deltaTime;
                directionp1 += new Vector3(+p1speed, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                player2.transform.position += new Vector3(+p2speed, 0, 0) * Time.deltaTime;
                directionp2 += new Vector3(+p2speed, 0, 0);
            }


            if (Input.GetKey(KeyCode.LeftShift))
            {
                p1speed = 2;
            }
            else
            {
                p1speed = 1;

            }

            if (Input.GetKey(KeyCode.RightControl))
            {
                p2speed = 2;
            }
            else
            {
                p2speed = 1;

            }


            directionplayer1.forward = directionp1;
            directionplayer2.forward = directionp2;
        }
        

    }
}
