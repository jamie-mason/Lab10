using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnePoint : MonoBehaviour
{
    CarController carController;
    public bool printOnce = true;
    public string RaycastReturn;
    public string RaycastTagReturn;
    public GameObject FoundObject;
    public float rayDistance = 0f;
    RaycastHit hit;
    private void Start()
    {
        carController = GameObject.Find("car").GetComponent<CarController>();

    }
    private void Update()
    {
        CheckRightSideUp();


    }
    private void FixedUpdate()
    {
        getCollision();
        
    }
    void CheckRightSideUp()
    {
        WheelCollider[] wheels = { carController.getFL(), carController.getFR(), carController.getRL(), carController.getRR() };

        Ray[] ray = {new Ray(wheels[0].transform.position, Vector3.down), new Ray(wheels[1].transform.position, Vector3.down),
            new Ray(wheels[2].transform.position, Vector3.down), new Ray(wheels[3].transform.position, Vector3.down)};

        //Only if all the wheel raycast don't collide I want it to return false;
        for (int i = 0; i < ray.Length; i++)
        {


            if (Physics.Raycast(ray[i], out hit, rayDistance))
            {
                RaycastTagReturn = hit.collider.gameObject.tag;
                break;
            }
            
            

        }
        //draw all the rays for visual
        for (int i = 0; i < ray.Length; i++)
        {
            Debug.DrawRay(ray[i].origin, ray[i].direction * 0.75f, Color.cyan);
            
        }
        if(RaycastTagReturn == "Point")
        {
            RaycastReturn = hit.collider.gameObject.name;
            FoundObject = GameObject.Find(RaycastReturn);
            if (printOnce)
            {
                Debug.Log(RaycastReturn);
                printOnce = false;
            }
        }
        
    }
    void getCollision()
    {
       
        
        
        
    }
}
