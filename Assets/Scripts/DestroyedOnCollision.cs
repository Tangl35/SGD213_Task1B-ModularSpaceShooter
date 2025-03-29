using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum TagListType
{
    Blacklist,
    Whitelist
}

public class DestroyedOnCollision : MonoBehaviour
{

    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // List to determine which object is destroyed.
    [SerializeField]
    private List<string> tags;

    void OnTriggerEnter2D(Collider2D other)
    {
        bool tagInList = tags.Contains(other.gameObject.tag);

        if (tagListType == TagListType.Blacklist && tagInList)
        {
            // Destroy if Blacklist and tag IS in Blacklist
            Destroy(gameObject);
        }

        else if (tagListType == TagListType.Whitelist && !tagInList)
        {
            // Destroy if Whitelist and tag is NOT in Whitelist
            Destroy(gameObject);
        }

        else
        {
            // Use default collision code
        }
    }
}
