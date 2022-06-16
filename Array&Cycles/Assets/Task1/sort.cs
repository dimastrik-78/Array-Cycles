using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class sort : MonoBehaviour
{
    [SerializeField] private Transform[] Box;
    private void Start()
    {
        Vector3 Spawn = new Vector3(-5, 0, 0);
        for (int i = 0; i < Box.Length - 1; i++)
        {
            for (int j = 0; j < Box.Length - i - 1; j++)
            {
                if (Box[j].localScale.magnitude < Box[j + 1].localScale.magnitude)
                {
                    Transform Loc = Box[j];
                    Box[j] = Box[j + 1];
                    Box[j + 1] = Loc;
                }
            }
        }
        for (int i = 0; i < Box.Length; i++)
        {
            Box[i].transform.position = Spawn;
            Spawn.x += Box[i].localScale.x;
        }
    }
}
