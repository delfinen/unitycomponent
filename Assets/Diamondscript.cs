using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamondscript : MonoBehaviour
{
    [Range (-720, 720)]
    public float rotationspeed; 
    public SpriteRenderer rend;
    public Color newColor;
    public Transform other;
    


    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(2f, 0f,5f);
      //other.position = new Vector3(3, 2, other.position.z);

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
        }


        transform.Translate(5f * Time.deltaTime, 0, 0, Space.Self);

    }
}
