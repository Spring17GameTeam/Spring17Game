using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour {

    public GameObject mountain;
    public GameObject village;
    public GameObject grass;
    


    Transform board;

    // The map size
    int width = 10;
    int height = 10;

    public void BoardMaker()
    {
        board = new GameObject("Board").transform;

        GameObject instance;

        // The max number of mountains and villages that can be randomly generated
        int mount = 10;
        int vill = 2;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                if (x == 0 & y == 0)
                    instance = Instantiate (village, new Vector3(x, y, 0f), Quaternion.identity);
                else if (x > 1 & y > 1 & x < 9 & y < 9)
                    instance = Instantiate(TileSelector(ref mount, ref vill), new Vector3(x, y, 0f), Quaternion.identity);
                else
                    instance = Instantiate(grass, new Vector3(x, y, 0f), Quaternion.identity);
                instance.transform.SetParent(board);
            }
        }
    }

    // Determines whether a given tile will be Grass, Mountains, or Village, based on how many of each are allowed and a random chance.
    GameObject TileSelector(ref int mount, ref int vill)
    {
        if (vill > 0)
            if (Random.Range(0, 20) > 18)
            {
                vill--;
                return village;
            }
        if (mount > 0)
            if (Random.Range(0,20) > 15)
                {
                    mount--;
                    return mountain;
                }
        return grass;
    }


}
