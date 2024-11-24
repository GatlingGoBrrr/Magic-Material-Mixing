using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDrop : MonoBehaviour
{
    public GameObject gameObject;

    public Collider2D collider2D;

    public ElementCombiner elementCombiner;
    public TestCombiner testCombiner;

    private GameObject collidedObject;
    
    Vector3 mousePositionOffset;


    //Get the elementCombiner class from LogicManager so that we can use the CombineElements function
    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "ExploreScene")
        {
            elementCombiner = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<ElementCombiner>();
        }
        
        else
        {
            testCombiner = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<TestCombiner>();
        }
            
    }

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collidedObject = collision.gameObject;
    }

    private void OnMouseUp()
    {
        if(collider2D.IsTouchingLayers())
        {
            elementCombiner.CombineElements(gameObject, collidedObject);
        }
    }
}
