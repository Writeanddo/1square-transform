using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StandUp : MonoBehaviour
{
	[SerializeField] private float rotateDuration; 

    // Start is called before the first frame update
    void Start()
    {
		Vector3 newRot = new Vector3(0,0,0);

		transform.DORotate(newRot, rotateDuration);
    }
}
