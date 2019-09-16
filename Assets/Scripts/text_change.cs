using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_change : MonoBehaviour
{
    // Start is called before the first frame update
    public Text my_text;
    void Start()
    {
        my_text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Location1.game_over)
        {
            if (Location1.current_turn == "b")
            {
                my_text.text = "Red Wins";
            }
            else
            {
                my_text.text = "Black Wins";
            }
        }
    }
}
