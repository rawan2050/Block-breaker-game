using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
   [SerializeField] int breakableBlocks; // Serialized for debugging purposes
    SceneLoader sceneloader; // cached reference
    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void countBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks <= 0)
        {
            sceneloader.NextScene();
        }
    }
}
