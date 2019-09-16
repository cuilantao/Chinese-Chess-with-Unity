using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_mover : MonoBehaviour
{
    private Rigidbody2D rigid;
    bool move_down = false;
    bool move_up = false;
    bool move_left = false;
    bool move_right = false;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKey(KeyCode.S);
        bool up = Input.GetKey(KeyCode.W);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);
        if (down)
        {
            move_down = true;
        }
        else if (up)
        {
            move_up = true;
        }
        else if (left)
        {
            move_left = true;
        }
        else if (right)
        {
            move_right = true;
        }
        if (!down && move_down)
        {
            if ((rigid.transform.position - new Vector3(0, 0.71f, 0)).y >= -3.41f)
            {
                rigid.transform.position = rigid.transform.position - new Vector3(0, 0.71f, 0);
            }
            move_down = false;
        }
        else if (!up && move_up)
        {
            if ((rigid.transform.position + new Vector3(0, 0.71f, 0)).y <= 3.1)
            {
                rigid.transform.position = rigid.transform.position + new Vector3(0, 0.71f, 0);
            }
            move_up = false;
        }
        else if (!left && move_left)
        {
            if ((rigid.transform.position - new Vector3(0.736f, 0, 0)).x >= -2.59)
            {
                rigid.transform.position = rigid.transform.position - new Vector3(0.736f, 0, 0);
            }
            move_left = false;
        }
        else if(!right && move_right)
        {
            if ((rigid.transform.position + new Vector3(0.736f, 0, 0)).x <= 3.33)
            {
                rigid.transform.position = rigid.transform.position + new Vector3(0.736f, 0, 0);
            }
            move_right = false;
        }
    }
}