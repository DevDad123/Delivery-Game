using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageon = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 nothasPackageon = new Color32(1, 1, 1, 1);
    bool haspackage;
    [SerializeField] float countdowndestroy;
    SpriteRenderer spriteRenderers;
    private void Start()
    {
        spriteRenderers = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hitted something");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !haspackage)
        {
            Debug.Log("Picked up the package");
            haspackage = true;
            Destroy(other.gameObject,countdowndestroy);
            spriteRenderers.color = hasPackageon;
        }
        if (other.tag == "Desination" && haspackage)
        {
            Debug.Log("Delivered");
            haspackage = false; 
            spriteRenderers.color = nothasPackageon;
        }
    }
}
