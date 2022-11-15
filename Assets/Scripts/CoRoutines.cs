using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutines : MonoBehaviour
{
    [SerializeField]
    public Transform StartPoint;
    [SerializeField]
    public Transform EndPoint;
    [SerializeField]
    public Transform LerpTarget;
    [SerializeField]
    public float Duration;
    [SerializeField]
    public float StartDelay;
    [SerializeField]
    private UI ui;
    [SerializeField]
    private Chest Chest;


    private CoRoutines routine;

    private void Start()
    {
        //StartCoroutine(doMove(LerpTarget, StartPoint.position, EndPoint.position, Duration, StartDelay));


        //StopCoroutine(routine);
        //StopAllCoroutines() to stop all on this monoscript



    }

    public IEnumerator doMove(Transform target, Vector3 start, Vector3 end, float duration, float delay)
    {
        target.position = start;
        
        yield return new WaitForSeconds(delay);
        
        
        float startTime = Time.time;
        float endTime = startTime + duration;

        while (Time.time < endTime)
        {
            float normTime = Mathf.InverseLerp(startTime, endTime, Time.time);
            target.position = Vector3.Lerp(start, end, normTime);

            //BAD WAY - don't use if you want to wait for one frame, more than that is fine
            //yield return new WaitForSeconds(0);

            //Good way 
            yield return null;


        }

        target.position = end;

        yield break;


    }

    private void OnTriggerEnter(Collider entered)
    {
        ui.ChestGetField.gameObject.SetActive(false);
    }





}
  
