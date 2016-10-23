using UnityEngine;
using System.Collections;

/**
 * Node class, holds stuff :)
 */
public class Node
{
    private string nodeName;
    private string text;
    private ArrayList neighbors;
    
    public Node(string nodeName)
    {
        this.nodeName = nodeName;
        this.neighbors = new ArrayList();
        this.text = "N/a";
    }

    public string getNodeName()
    {
        return this.nodeName;
    }

    public void addNeighbors(ArrayList neighbors)
    {
        foreach (Node i in neighbors)
        {
            this.neighbors.Add(i);
        }
    }

    // setText function

    public string getText()
    {
        return this.text;
    }
}
