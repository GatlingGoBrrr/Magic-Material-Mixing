using UnityEngine;

public class DragDrop : MonoBehaviour
{
    public GameObject gameObject;

    public Collider2D collider2D;
    
    Vector3 mousePositionOffset;

    //obtains world mouse position so that it can be used in other functions requiring world space instead of screen space
    private Vector3 GetWorldMousePosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        //Creates offset so that the object moves relative to where it's being clicked, not the center of the object
        mousePositionOffset = gameObject.transform.position - GetWorldMousePosition();
        //Debug.Log("On mouse down");
    }

    private void OnMouseDrag()
    {
        transform.position = GetWorldMousePosition() + mousePositionOffset;
    }

    private void OnMouseUp()
    {
        Debug.Log("Is touching: " + collider2D.IsTouchingLayers());
    }
}
