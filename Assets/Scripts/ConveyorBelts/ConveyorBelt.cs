using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Directions currentDirection;

    [SerializeField]
    private List<GameObject> itemsOnBelt;
    void Start()
    {
        currentDirection = Directions.North;
        itemsOnBelt = new List<GameObject>(){null,null,null,null,null,null,null,null,null,null,null,null,null,null,null};
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnDrawGizmosSelected()
    {
        // Draws a blue line from this transform to the target
        Gizmos.color = Color.blue;

        Vector3 topMiddle = transform.position;
        topMiddle.y += transform.localScale.y / 2;
        Vector3 startPoint = topMiddle;
        
        switch (currentDirection) {
            case Directions.North:
                // Vector3.forward
                startPoint.z += transform.localScale.z / 2;
                Vector3 endPointNorth = startPoint;
                endPointNorth.z = endPointNorth.z - 1;
                Gizmos.DrawLine(startPoint, endPointNorth);

                Vector3 arrowEndPointNorth = new Vector3(transform.localScale.x / 2, 0, 0);
                Gizmos.DrawLine(endPointNorth, topMiddle + arrowEndPointNorth);
                Gizmos.DrawLine(endPointNorth, topMiddle - arrowEndPointNorth);
                
                break;
            case Directions.East:
                // Vector3.right
                
                startPoint.x -= transform.localScale.x / 2;
                Vector3 endPointEast = startPoint;
                endPointEast.x = endPointEast.x + 1;
                Gizmos.DrawLine(startPoint, endPointEast);

                Vector3 arrowEndPointEast = new Vector3(0, 0, transform.localScale.z / 2);
                Gizmos.DrawLine(endPointEast, topMiddle + arrowEndPointEast);
                Gizmos.DrawLine(endPointEast, topMiddle - arrowEndPointEast);
                break;
            case Directions.South:
                // Vector3.back
                startPoint.z -= transform.localScale.z / 2;
                Vector3 endPointSouth = startPoint;
                endPointSouth.z = endPointSouth.z + 1;
                Gizmos.DrawLine(startPoint, endPointSouth);

                Vector3 arrowEndPointSouth = new Vector3(transform.localScale.x / 2, 0, 0);
                Gizmos.DrawLine(endPointSouth, topMiddle + arrowEndPointSouth);
                Gizmos.DrawLine(endPointSouth, topMiddle - arrowEndPointSouth);
                break;
            case Directions.West:
                // Vector3.left
                startPoint.x += transform.localScale.x / 2;
                Vector3 endPointWest = startPoint;
                endPointWest.x = endPointWest.x - 1;
                Gizmos.DrawLine(startPoint, endPointWest);

                Vector3 arrowEndPointWest = new Vector3(0, 0, transform.localScale.z / 2);
                Gizmos.DrawLine(endPointWest, topMiddle + arrowEndPointWest);
                Gizmos.DrawLine(endPointWest, topMiddle - arrowEndPointWest);
                
                break;
        }
    }
}
