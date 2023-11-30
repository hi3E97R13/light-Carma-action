using UnityEngine;

public class TruckFollow : MonoBehaviour
{
    #region Fields
 
    private Vector3 targetchords;
   
    //   | CAMERA WILL MATCH ROTATION OF ANY OBJECT YOUR STICK IN HERE|
    //   v                                                            v
    public Transform player;
    //   ^                                                            ^
    //   |                                                            |
 
    public float Turnspeed = 2.0f;
    public Quaternion Turnto;
 
    [Header(header: "Offset")]
    public Vector3 offset;
 
    #endregion
 
    private void Start()
    {
        targetchords = player.transform.position;
    }
 
    void Update()
    {
        Turnto = player.transform.rotation;
        transform.position = player.transform.position + offset;
        transform.rotation = Quaternion.Slerp(transform.rotation, Turnto, Time.deltaTime * Turnspeed);
    }
}
