using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    //PSEUDO: DECLARE PUBLIC VARIABLE OF TYPE FLOAT FOR SPEED;
    public float speed = 50.0f;
    void Update()
    {
        
    }

   
    void OnMouseDrag()
    {
        //TRY:
        // Declare and Initialize the X and Y mouse axes and multiply by speed.
        // The value is in the range -1 to 1
        //Mouse Y will become Z translation
        //float transX = Input.GetAxis("Mouse X") * speed;
        //float transZ = Input.GetAxis("Mouse Y") * speed;

        // MAKE TRANSLATION VARIABLE MOVE AT 10 METERS PER SECOND INSTEAD OF 10 METERS PER FRAME WITH TimeDeltaTime. . .
        //transX *= Time.deltaTime;
        //transZ *= Time.deltaTime;

        // use transform to translate with values above
        ////Move translation along the object's x and z-axis
        //transform.Translate(transX, 0, transZ);

        //Try Stretch Task in tutorial sheet
        //USE:

        //Mouse in is screen space, not world space!
        //Get new Z distance from Camera to Object in teh Screen to select object
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //Get new Vector3 for mouse Input X,Y (Unused), Z(Camera-Object ScreenSpace dist var)
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,distance_to_screen));

        //Opject transform is Vector3 of Mouse Input X and Screen Move Z, Y is Static
        transform.position = new Vector3(pos_move.x, transform.position.y, pos_move.z);

    }
}
