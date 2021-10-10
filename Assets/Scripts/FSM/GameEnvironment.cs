using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class GameEnvironment
{
    private static GameEnvironment instance;
    private List<GameObject> _checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return _checkpoints;  } }
   
    public static GameEnvironment Instance
    {
        get 
        { 
            if(instance == null)
            {
                instance = new GameEnvironment();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("PatrolPoint"));

                instance._checkpoints = instance._checkpoints.OrderBy(waypoint => waypoint.name).ToList();
            }
            return instance;
        }
    }
}
