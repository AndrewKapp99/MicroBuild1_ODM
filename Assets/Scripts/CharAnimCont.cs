using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAnimCont : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject PlayerObj;
    private CharMove cMove;
    // Start is called before the first frame update
    void Start()
    {
        cMove = PlayerObj.GetComponent<CharMove>();
    }

    // Update is called once per frame
    void Update()
    {
        float X = cMove.z;
        float Y = cMove.y;
        float Z = cMove.x;

        if (Mathf.Abs(X) > 0.2)
        {
            anim.SetFloat("FwdParam", X);
        }
        else if (Mathf.Abs(Z) > 0.2)
        {
            anim.SetFloat("RtParam", Z);
        }
        else
        {
            anim.SetFloat("FwdParam", 0);
            anim.SetFloat("RtParam", 0);
        }

        Debug.Log($"{X}, {Y}, {Z}");
    }
}
