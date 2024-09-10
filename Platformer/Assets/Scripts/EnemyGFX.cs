using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{

    public AIPath aiPath;

    private Vector3 origionalScale;

    // Start is called before the first frame update
    void Start()
    {
        origionalScale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f){
            transform.localScale = new Vector3(Mathf.Abs(origionalScale.x), origionalScale.y, origionalScale.z);

        }else if(aiPath.desiredVelocity.x <= -0.01f){
            transform.localScale = new Vector3(-Mathf.Abs(origionalScale.x), origionalScale.y, origionalScale.z);
        }
        
    }
}
