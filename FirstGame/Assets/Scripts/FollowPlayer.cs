
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    void Start()
    {
        
    }


    void Update()
    {
        //pozycja tego ! obieku ?
        // akcja pierowszo osobowa 
        
        transform.position = player.position + offset;
    }
}
