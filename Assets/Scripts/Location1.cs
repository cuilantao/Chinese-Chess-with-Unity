using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location1 : MonoBehaviour
{
    public static string most_recent;
    public static string current_turn = "b";
    public static bool game_over = false;
    public static int[] red_car_1 = { 9, 0 };
    public static int[] red_horse_1 = { 9, 1 };
    public static int[] red_elephant_1 = { 9, 2 };
    public static int[] red_guard_1 = { 9, 3 };
    public static int[] red_general = { 9, 4 };
    public static int[] red_guard_2 = { 9, 5 };
    public static int[] red_elephant_2 = { 9, 6 };
    public static int[] red_horse_2 = { 9, 7 };
    public static int[] red_car_2 = { 9, 8 };
    public static int[] red_canon_1 = { 7, 1 };
    public static int[] red_canon_2 = { 7, 7 };
    public static int[] red_minion_1 = { 6, 0 };
    public static int[] red_minion_2 = { 6, 2 };
    public static int[] red_minion_3 = { 6, 4 };
    public static int[] red_minion_4 = { 6, 6 };
    public static int[] red_minion_5 = { 6, 8 };
    public static int[] black_minion_1 = { 3, 0 };
    public static int[] black_minion_2 = { 3, 2 };
    public static int[] black_minion_3 = { 3, 4 };
    public static int[] black_minion_4 = { 3, 6 };
    public static int[] black_minion_5 = { 3, 8 };
    public static int[] black_canon_1 = { 2, 1 };
    public static int[] black_canon_2 = { 2, 7 };
    public static int[] black_car_1 = { 0, 0 };
    public static int[] black_car_2 = { 0, 8 };
    public static int[] black_horse_1 = { 0, 1 };
    public static int[] black_horse_2 = { 0, 7 };
    public static int[] black_elephant_1 = { 0, 2 };
    public static int[] black_elephant_2 = { 0, 6 };
    public static int[] black_guard_1 = { 0, 3 };
    public static int[] black_guard_2 = { 0, 5 };
    public static int[] black_general = { 0, 4 };
    public static bool[][] occupied = new bool[10][];
    public static string[][] occupied_flag = new string[10][];

    // Start is called before the first frame update
    void Start()
    {
        red_car_1[0] = 9;
        red_car_1[1] = 0;
        red_horse_1[0] = 9;
        red_horse_1[1] = 1;
        red_elephant_1[0] = 9;
        red_elephant_1[1] = 2;
        red_guard_1[0] = 9;
        red_guard_1[1] = 3;
        red_general[0] = 9;
        red_general[1] = 4;
        red_guard_2[0] = 9;
        red_guard_2[1] = 5;
        red_elephant_2[0] = 9;
        red_elephant_2[1] = 6;
        red_horse_2[0] = 9;
        red_horse_2[1] = 7;
        red_car_2[0] = 9;
        red_car_2[1] = 8;
        red_canon_1[0] = 7;
        red_canon_1[1] = 1;
        red_canon_2[0] = 7;
        red_canon_2[1] = 7;
        red_minion_1[0] = 6;
        red_minion_1[1] = 0;
        red_minion_2[0] = 6;
        red_minion_2[1] = 2;
        red_minion_3[0] = 6;
        red_minion_3[1] = 4;
        red_minion_4[0] = 6;
        red_minion_4[1] = 6;
        red_minion_5[0] = 6;
        red_minion_5[1] = 8;
        black_minion_1[0] = 3;
        black_minion_1[1] = 0;
        black_minion_2[0] = 3;
        black_minion_2[1] = 2;
        black_minion_3[0] = 3;
        black_minion_3[1] = 4;
        black_minion_4[0] = 3;
        black_minion_4[1] = 6;
        black_minion_5[0] = 3;
        black_minion_5[1] = 8;
        black_canon_1[0] = 2;
        black_canon_1[1] = 1;
        black_canon_2[0] = 2;
        black_canon_2[1] = 7;
        black_car_1[0] = 0;
        black_car_1[1] = 0;
        black_horse_1[0] = 0;
        black_horse_1[1] = 1;
        black_guard_1[0] = 0;
        black_guard_1[1] = 3;
        black_elephant_1[0] = 0;
        black_elephant_1[1] = 2 ;
        black_general[0] = 0;
        black_general[1] = 4;
        black_guard_2[0] = 0;
        black_guard_2[1] = 5;
        black_elephant_2[0] = 0;
        black_elephant_2[1] = 6;
        black_horse_2[0] = 0;
        black_horse_2[1] = 7;
        black_car_2[0] = 0;
        black_car_2[1] = 8;
        init_oc(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void init_oc()
    {
        for (int i=0;i<occupied .Length; i++)
        {
            occupied[i] = new bool[9];
            occupied_flag[i] = new string[9];
        }
        for (int i = 0; i < occupied.Length; i++)
        {
            for (int j = 0; j < occupied[i].Length; j++)
            {
                occupied[i][j] = false;
                occupied_flag[i][j] = ""; 
            }
        }
        for (int i = 0; i < 9; i++)
        {
            occupied[9][i] = true;
            occupied_flag[9][i] = "r";
            occupied[0][i] = true;
            occupied_flag[0][i] = "b";
        }
        for (int i = 0; i < 5; i++)
        {
            occupied[6][i * 2] = false;
            occupied_flag[6][i * 2] = "r";
            occupied[3][i * 2] = false;
            occupied_flag[3][i * 2] = "b";
        }
        occupied[7][1] = true;
        occupied_flag[7][1] = "r";
        occupied[7][7] = true;
        occupied_flag[7][7] = "r";
        occupied[2][1] = true;
        occupied_flag[2][1] = "b";
        occupied[2][7] = true;
        occupied_flag[2][7] = "b";
    }
    public static bool is_valid_move(string tag, int[] target) //decide whether the move is valid
    {
        if (!general_facing_eachother(tag, target))
        {
            return false;
        }
        if (tag.Substring(0, tag.Length - 1) == "redminion" || tag.Substring(0, tag.Length - 1) == "blackminion") //If we want to move a minion.
        {
            return minion_valid(tag, target);
        }
        else if (tag.Substring(0, tag.Length - 1) == "blackcar" || tag.Substring(0, tag.Length - 1) == "redcar") //If we want to move a minion.
        {
            return car_valid(tag, target);
        }
        else if (tag.Substring(0, tag.Length - 1) == "blackhorse" || tag.Substring(0, tag.Length - 1) == "redhorse") //If we want to move a minion.
        {
            return horse_valid(tag, target);
        }
        else if (tag.Substring(0, tag.Length - 1) == "blackelephant" || tag.Substring(0, tag.Length - 1) == "redelephant") //If we want to move a minion.
        {
            return elephant_valid(tag, target);
        }
        else if (tag.Substring(0, tag.Length - 1) == "blackguard" || tag.Substring(0, tag.Length - 1) == "redguard") //If we want to move a minion.
        {
            return guard_valid(tag, target);
        }
        else if (tag.Substring(0, tag.Length - 1) == "blackcanon" || tag.Substring(0, tag.Length - 1) == "redcanon") //If we want to move a minion.
        {
            return canon_valid(tag, target);
        }
        return general_valid(tag, target);
    }
    public static bool minion_valid(string tag, int[] target) // determine whether minion moves valid
    {
        if (tag.Substring(0, tag.Length - 1) == "blackminion")
        {
            int[] cur_loc = get_loc(tag);
            if (cur_loc[0] >= 5)
            {
                if ((target[0] - cur_loc[0] <= 1) && (target[0] - cur_loc[0] >= 0) && Mathf.Abs((target[1] - cur_loc[1])) <= 1)
                {
                    if (occupied_flag[target[0]][target[1]] == tag.Substring(0, 1))
                    {
                        return false;
                    }
                    return true;
                }
                return false;
            }
            else
            {
                if (target[0] - cur_loc[0] == 1 && target[1] == cur_loc[1])
                {
                    if (occupied_flag[target[0]][target[1]] == tag.Substring(0, 1))
                    {
                        return false;
                    }
                    return true;
                }
                return false;
            }
        }
        else
        {
            int[] cur_loc = get_loc(tag);
            if (cur_loc[0] <= 4)
            {
                if ((target[0] - cur_loc[0] >= -1) && (target[0] - cur_loc[0] <= 0) && Mathf.Abs((target[1] - cur_loc[1])) <= 1)
                {
                    if (occupied_flag[target[0]][target[1]] == tag.Substring(0, 1))
                    {
                        return false;
                    }
                    return true;
                }
                return false;
            }
            else
            {
                if (target[0] - cur_loc[0] == -1 && target[1] == cur_loc[1])
                {
                    if (occupied_flag[target[0]][target[1]] == tag.Substring(0, 1))
                    {
                        return false;
                    }
                    return true;
                }
                return false;
            }
        }
    }
    public static bool horse_valid(string tag, int[] target) //check if horse move is valid
    {
        int[] cur_loc = get_loc(tag);
        if ((Mathf.Abs(target[1]-cur_loc[1]) == 2 && Mathf.Abs(target[0]-cur_loc[0]) == 1))
        {
            if (target[1] > cur_loc[1])
            {
                if (occupied_flag[cur_loc[0]][target[1]-1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (occupied_flag[cur_loc[0]][target[1] + 1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
        }
        else if ((Mathf.Abs(target[1] - cur_loc[1]) == 1 && Mathf.Abs(target[0] - cur_loc[0]) == 2))
        {
            if (target[0] > cur_loc[0])
            {
                if (occupied_flag[cur_loc[0]+1][cur_loc[1]] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (occupied_flag[cur_loc[0] - 1][cur_loc[1]] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
        }
        return false;
    }
    public static bool elephant_valid(string tag, int[] target)
    {
        int[] cur_loc = get_loc(tag);
        if (current_turn == "r")
        {
            if (target[0] < 5)
            {
                return false;
            }
        }
        else
        {
            if (target[0] > 4)
            {
                return false;
            }
        }
        if (Mathf.Abs(cur_loc[0] - target[0]) != 2 || Mathf.Abs(cur_loc[1] - target[1]) != 2)
        {
            return false;
        }
        else
        {
            if (target[0] > cur_loc[0])
            {
                if (target[1] > cur_loc[1])
                {
                    if (occupied_flag[target[0]-1][target[1]-1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0,1))
                    {
                        return true;
                    }
                }
                else
                {
                    if (occupied_flag[target[0] + 1][target[1] - 1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (target[1] > cur_loc[1])
                {
                    if (occupied_flag[target[0] + 1][target[1] - 1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                    {
                        return true;
                    }
                }
                else
                {
                    if (occupied_flag[target[0] + 1][target[1] + 1] == "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public static bool car_valid(string tag, int[] target) // check if car move is valid
    {
        int[] cur_loc = get_loc(tag);
        if (target[0] != cur_loc[0] && target[1] != cur_loc[1])
        {
            return false;
        }
        else
        {
            if (target[0] == cur_loc[0])
            {
                int start = Mathf.Min(cur_loc[1], target[1]);
                int end = Mathf.Max(cur_loc[1], target[1]);
                for (int i = start+1; i < end; i++)
                {
                    if (occupied_flag[target[0]][i] != "")
                    {
                        return false;
                    }
                }
                if (occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
            else
            {
                int start = Mathf.Min(cur_loc[0], target[0]);
                int end = Mathf.Max(cur_loc[0], target[0]);
                for (int i = start + 1; i < end; i++)
                {
                    if (occupied_flag[i][target[1]] != "")
                    {
                        return false;
                    }
                }
                if (occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
                {
                    return true;
                }
                return false;
            }
        }
    }
    public static bool guard_valid(string tag, int[] target)
    {
        int[] cur_loc = get_loc(tag);
        if (tag.Substring(0,1) == "b")
        {
            if (target[0]>2 || target[1]>5 || target[1] < 3)
            {
                return false;
            }
        }
        else
        {
            if (target[0]<7 || target[1] > 5 || target[1] < 3)
            {
                return false;
            }
        }
        return (Mathf.Abs(target[1] - cur_loc[1]) == 1 && Mathf.Abs(target[0] - cur_loc[0])==1 && occupied_flag[target[0]][target[1]] != tag.Substring(0,1));
    }//check if the guard made a valid move
    public static bool canon_valid(string tag, int[] target)
    {
        int[] cur_loc = get_loc(tag);

        if (cur_loc[0] != target[0] && cur_loc[1] != target[1])
        {
            return false;
        }
        else
        {
            if (cur_loc[0] == target[0])
            {
                int obs = 0;
                int start = Mathf.Min(target[1], cur_loc[1]);
                int end = Mathf.Max(target[1], cur_loc[1]);
                for (int i = start + 1; i < end; i++)
                {
                    if (occupied_flag[cur_loc[0]][i] != "")
                    {
                        obs += 1;
                    }
                }
                if (obs==0)
                {
                    return (occupied_flag[target[0]][target[1]] == "");
                }
                return (obs == 1 && occupied_flag[target[0]][target[1]] != "" && occupied_flag[target[0]][target[1]] != tag.Substring(0,1));
            }
            else
            {
                int obs = 0;
                int start = Mathf.Min(target[0], cur_loc[0]);
                int end = Mathf.Max(target[0], cur_loc[0]);
                for (int i = start + 1; i < end; i++)
                {
                    if (occupied_flag[i][cur_loc[1]] != "")
                    {
                        obs += 1;
                    }
                }
                if (obs == 0)
                {
                    return (occupied_flag[target[0]][target[1]] == "");
                }
                return (obs == 1 && occupied_flag[target[0]][target[1]] != "" && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1));
            }
        }
    }
    public static bool general_valid(string tag, int[] target)
    {
        int[] cur_loc = get_loc(tag);
        if ((target[1] < 3 || target[1] > 5 || target[0] > 2) && tag.Substring(0,1) == "b")
            {
                return false;
            }
        if ((target[1] < 3 || target[1] > 5 || target[0] < 7) && tag.Substring(0, 1) == "r")
        {
            return false;
        }
        if (target[1] == black_general[1] || target[1] == red_general[1])
        {
            if ((Mathf.Abs(target[0] - cur_loc[0]) + Mathf.Abs(target[1] - cur_loc[1]) == 1) && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1))
            {
                if (tag.Substring(0,1) == "b")
                {
                    for (int i = target[0] + 1; i < get_loc("redgeneral")[0]; i++)
                    {
                        if (occupied_flag[i][target[1]] != "" && target[0] != i)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            return false;
        }
        return ((Mathf.Abs(target[0] - cur_loc[0]) + Mathf.Abs(target[1] - cur_loc[1]) == 1) && occupied_flag[target[0]][target[1]] != tag.Substring(0, 1));
    }
    public static bool general_facing_eachother(string tag, int[] target)
    {
        int[] black_pos = get_loc("blackgeneral");
        int[] red_pos = get_loc("redgeneral");
        int x = 0;
        if ((black_pos[1] != red_pos[1])) 
        {
            return true;
        }
        else
        {
            int oc = 0;
            for (int i = black_pos[0] + 1; i < red_pos[0]; i++)
            {
                if (occupied_flag[i][black_pos[1]] != "")
                {
                    oc += 1;
                    x = i;
                }
            }
            if (oc > 1)
            {
                return true;
            }
            return ((get_loc(tag)[0] != x || get_loc(tag)[1] != black_pos[1]) || target[1] == black_pos[1]);
        }
    } 
    public static int[] get_loc(string tag)
    {
        if (tag == "blackminion1")
        {
            return black_minion_1;
        }
        else if (tag == "blackminion3")
        {
            return black_minion_2;
        }
        else if(tag == "blackminion2")
        {
            return black_minion_3;
        }
        else if(tag == "blackminion4")
        {
            return black_minion_4;
        }
        else if(tag == "blackminion5")
        {
            return black_minion_5;
        }
        else if(tag == "blackcanon2")
        {
            return black_canon_1;
        }
        else if(tag == "blackcanon1")
        {
            return black_canon_2;
        }
        else if(tag == "blackcar2")
        {
            return black_car_1;
        }
        else if(tag == "blackhorse1")
        {
            return black_horse_1;
        }
        else if(tag == "blackelephant1")
        {
            return black_elephant_1;
        }
        else if(tag == "blackguard2")
        {
            return black_guard_1;
        }
        else if(tag == "blackgeneral")
        {
            return black_general;
        }
        else if (tag == "blackguard1")
        {
            return black_guard_2;
        }
        else if (tag == "blackelephant2")
        {
            return black_elephant_2;
        }
        else if (tag == "blackhorse2")
        {
            return black_horse_2;
        }
        else if (tag == "blackcar1")
        {
            return black_car_2;
        }
        else if (tag == "redminion1")
        {
            return red_minion_1;
        }
        else if (tag == "redminion2")
        {
            return red_minion_2;
        }
        else if (tag == "redminion3")
        {
            return red_minion_3;
        }
        else if (tag == "redminion4")
        {
            return red_minion_4;
        }
        else if(tag == "redminion5")
        {
            return red_minion_5;
        }
        else if (tag == "redcanon2")
        {
            return red_canon_1;
        }
        else if (tag == "redcanon1")
        {
            return red_canon_2;
        }
        else if (tag == "redcar1")
        {
            return red_car_1;
        }
        else if (tag == "redhorse1")
        {
            return red_horse_1;
        }
        else if(tag == "redelephant1")
        {
            return red_elephant_1;
        }
        else if(tag == "redguard2")
        {
            return red_guard_1;
        }
        else if (tag == "redgeneral")
        {
            return red_general;
        }
        else if (tag == "redguard1")
        {
            return red_guard_2;
        }
        else if(tag == "redelephant2")
        {
            return red_elephant_2;
        }
        else if (tag == "redhorse2")
        {
            return red_horse_2;
        }
        return red_car_2;
    }
}
