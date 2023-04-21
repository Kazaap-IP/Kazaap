using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick2()
    {
        if (GameManager.end2 == 0)
        {
            GameManager.end2 = 1;
            GameManager.both = 2;
            if (GameManager.end1 == 1)
            {
                GameManager.both = 3;
            }
        }
    }
}
