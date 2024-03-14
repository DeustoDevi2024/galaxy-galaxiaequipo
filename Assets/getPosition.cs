using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPosition : MonoBehaviour
{

    public float speedMultiplier = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
        void Update()
    {
        checkMovement();

        rotate();
    }

    private void rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -speedMultiplier * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speedMultiplier * Time.deltaTime);
        }        
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left * speedMultiplier * Time.deltaTime);
        }        
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * -speedMultiplier * Time.deltaTime);
        }
        
    }

    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speedMultiplier * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speedMultiplier * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speedMultiplier * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speedMultiplier * Time.deltaTime);
        }
                else if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * speedMultiplier * Time.deltaTime);
        }
                else if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * speedMultiplier * Time.deltaTime);
        }
    }
}
