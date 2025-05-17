using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Basic inventory system for storing collected items.
/// </summary>
public class Inventory : MonoBehaviour
{
    private readonly List<string> items = new();

    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log($"Picked up: {item}");
    }

    public bool Contains(string item) => items.Contains(item);
}
