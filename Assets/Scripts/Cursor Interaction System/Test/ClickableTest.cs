using UnityEngine;

public class ClickableTest : MonoBehaviour, ICursorClickable
{
    public void OnCursorClick(RaycastHit hit)
    {
        Debug.Log("OnCursorClick triggered on " + gameObject.name);
    }

    public void OnCursorHover(RaycastHit hit)
    {
        Debug.Log("OnCursorHover triggered on " + gameObject.name);
    }
}