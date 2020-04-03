using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public int minTrees;
    public int maxTrees;

    public GameObject[] trees;

    void Start()
    {
        int numTrees = Random.Range(minTrees, maxTrees + 1);
        for(var i = 0; i <= numTrees; i++)
        {
            int treeType = Random.Range(0, 2);
            GameObject tree = trees[treeType];
            tree.transform.Rotate(0f, 0f, Random.Range(0f, 360f));
            Instantiate(tree, transform);
        }
    }
}
