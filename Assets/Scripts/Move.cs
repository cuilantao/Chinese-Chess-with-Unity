using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public bool clicked = false;
    public bool moved;
    public Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        bool buttondown = Input.GetKey(KeyCode.K);
        if (Location1.most_recent == gameObject.transform.tag)
        {
            if (buttondown && !moved && gameObject.transform.tag.Substring(0,1) == Location1.current_turn)
            {
                int[] loc = Location1.get_loc(gameObject.transform.tag); //update location
                Vector2 target_loc = GameObject.FindGameObjectWithTag("target").transform.position;
                double tmp = (target_loc.x + 2.575)/0.736;
                double tmp1 = (target_loc.y + 3.383) / 0.71;
                int y_cor = (int)(tmp+0.01);
                int x_cor = (int)(tmp1+0.01);
                int[] select_loc = {x_cor, y_cor};
                if (Location1.is_valid_move(gameObject.transform.tag, select_loc))
                {
                    Vector3 displacement;
                    displacement.x = (y_cor - loc[1]) * 0.7365f;
                    displacement.y = (x_cor - loc[0]) * 0.705f;
                    displacement.z = 0;
                    gameObject.transform.position += displacement;
                    moved = true;
                    if (gameObject.transform.tag.Substring(0,1) == "b")
                    {
                        Location1.occupied_flag[loc[0]][loc[1]] = "";
                        loc[0] = x_cor;
                        loc[1] = y_cor;
                        Location1.occupied_flag[loc[0]][loc[1]] = "b";
                    }
                    else
                    {
                        Location1.occupied_flag[loc[0]][loc[1]] = "";
                        loc[0] = x_cor;
                        loc[1] = y_cor;
                        Location1.occupied_flag[loc[0]][loc[1]] = "r";
                    }
                    if (gameObject.transform.tag.Substring(0,1) == "r")
                    {
                        Location1.current_turn = "b";
                    }
                    else
                    {
                        Location1.current_turn = "r";
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Location1.most_recent == gameObject.transform.tag)
        {
            string col = collision.gameObject.tag;
            Destroy(GameObject.FindGameObjectWithTag(col));
            if (col == "redgeneral" || col == "blackgeneral")
            {
                Location1.game_over = true;
            }
        }
    }
    void OnMouseDown()
    {
        clicked = true;
        Location1.most_recent = gameObject.transform.tag;
        moved = false;
    }
}
