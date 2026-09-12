using UnityEngine;

public class playermoving : MonoBehaviour
{
    public float maxspeed;

    public float maxrotation;
    float mousex, mousey;
    

    
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            mazemover();
        }
    }

    public void mazemover()
    {
        // writing the code 
        mousex += Input.GetAxis("Mouse X");
        mousey += Input.GetAxis("Mouse Y");
        float  x = mousex*maxspeed;
        float y = mousey*maxspeed;
        x=Mathf.Clamp(x, -maxrotation, maxrotation);
        y=Mathf.Clamp(y,-maxrotation, maxrotation);
        transform.localRotation = Quaternion.Euler(x, transform.rotation.y, y);
    }
}
