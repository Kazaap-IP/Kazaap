using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End1 : MonoBehaviour
{
    public void OnClick1() { 
        if (GameManager.end1 == 0)
        {
            GameManager.end1 = 1;
            GameManager.both = 1;
            if(GameManager.end2 == 1)
            {
                GameManager.both = 3;
            }
        }
    }
}
