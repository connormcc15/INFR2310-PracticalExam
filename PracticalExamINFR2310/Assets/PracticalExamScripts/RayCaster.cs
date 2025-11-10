using UnityEngine;

public class RayCaster : MonoBehaviour
{

    private Camera cam;//Camera Object
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        //If the mouse is clicked, the camera moves to that position
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.point);  //point is a position x,y,z  e.g. this.transform.position = hit.point
            }
        }
    }
}

