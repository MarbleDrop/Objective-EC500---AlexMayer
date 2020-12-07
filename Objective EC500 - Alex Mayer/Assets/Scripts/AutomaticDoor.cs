using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    public enum AutomaticDoorState { None, Open, Close }

    [Header("References")]
    [SerializeField] Transform rightDoor = null;
    [SerializeField] Transform leftDoor = null;

    [Header("Settings")]
    [SerializeField] LayerMask layersToDetect = 0;
    [Range(1, 10)]
    [SerializeField] float speed = 5;
    [Range(.5f, 4.0f)]
    [SerializeField] float delay = 1;

    [SerializeField] float closeXPos = 0.0f;
    [SerializeField] float openXPos = 0.0f;

    [Header("Audio")]
    [SerializeField] AudioClip openSFX = null;
    [SerializeField] AudioClip closeSFX = null;

    #region Private
    private bool animating = false;
    private AutomaticDoorState animatingState = AutomaticDoorState.None;

    private AutomaticDoorState state = AutomaticDoorState.None;

    private List<Transform> inRange = new List<Transform>();

    private AudioSource source = null;
    public AudioSource Source
    {
        get
        {
            if (source == null)
            {
                source = GetComponent<AudioSource>();
                if (source == null)
                {
                    source = gameObject.AddComponent<AudioSource>();
                }
            }
            return source;
        }
    }

    IEnumerator IE_StartAnimating = null, IE_Animate = null, IE_RightDoor = null, IE_LeftDoor = null;

    #endregion

    private void Start()
    {
        closeXPos = Mathf.Abs(leftDoor.transform.position.x);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trophy"))
        {
            if (((1 << other.gameObject.layer) & layersToDetect) == 0) { return; }

            inRange.Add(other.transform);

            state = AutomaticDoorState.Open;
            startAnimating();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Trophy"))
        {
            if (((1 << other.gameObject.layer) & layersToDetect) == 0) { return; }

            inRange.Remove(other.transform);

            if (inRange.Count <= 0)
            { state = AutomaticDoorState.Close; startAnimating(); }
        }
    }
    void startAnimating()
    {
        if (IE_StartAnimating != null)
        { StopCoroutine(IE_StartAnimating); }

        IE_StartAnimating = Begin();
        StartCoroutine(IE_StartAnimating);
    }
    private IEnumerator Begin()
    {
        while (animating) { yield return null; }

        if(IE_Animate != null) { StopCoroutine(IE_Animate); }
        IE_Animate = Animate(state.Equals(AutomaticDoorState.Open) ? openXPos : closeXPos);

        StartCoroutine(IE_Animate);
    }
    private IEnumerator Animate(float xPos)
    {
        if (Utility.Approximately(leftDoor.transform.position.x, xPos, .001f)) { yield break; }

        animatingState = state;

        yield return new WaitForSeconds(delay);

        if(IE_RightDoor != null) { StopCoroutine(IE_RightDoor); }
        if (IE_LeftDoor != null) { StopCoroutine(IE_LeftDoor); }

        IE_RightDoor = Move(rightDoor, -xPos);
        IE_LeftDoor = Move(leftDoor, xPos);

        

        StartCoroutine(IE_LeftDoor);
        StartCoroutine(IE_RightDoor);

        while (animating)
        {
            yield return null;
        }
    }
    
    IEnumerator Move(Transform transform, float xPos)
    {
        animating = true;
        while (Utility.Approximately(transform.localPosition.x, xPos, .001f))
        {
            float newXPos = transform.localPosition.x;
            newXPos = Mathf.Lerp(newXPos, xPos, speed * Time.deltaTime);
            transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
            yield return null;
        }
        animating = false;
    }
}