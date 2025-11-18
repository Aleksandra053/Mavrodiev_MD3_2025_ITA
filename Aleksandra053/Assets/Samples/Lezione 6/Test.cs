using UnityEngine;

public class Test : MonoBehaviour
{

    [Header("Base Value-Type Variables")]
    //Base Type Variables
    public int MyInt = 5;
    public float MyFloat = 1.5f;
    public string Mystring = "HelloWorld";
    public bool MyBool = false;


    [Header("Composite Value-Type Variables")]
    //Composite/Struct Type Variables
    public Vector2 MyVector2 = new Vector2(1.124f, 2.45f);
    public Vector3 MyVector3 = new Vector3(1.124f, 2.45f, 3.45f);
    public Color MyColor = new Color(r: 0.124f, g: 0.45f, b: 0.789f, a: 1f);

    [Header("Reference-Type Variables")]
    //Composite/Struct Type Variables
    public GameObject MyGameObject;
    public Camera MyCamera;
    public Material MyMaterial;
    public MeshCollider MeshCollider;







    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Debug.Log("Start method executed");

     MyInt = 10;
     MyFloat = 2.5f;
     Mystring = "HelloWorld";
     MyBool = true;

  MyVector2 = new Vector2(1.200f, 2.45f);
  MyVector3 = new Vector3(1.200f, 2.45f, 3.45f);
  MyColor = new Color(r: 0.124f, g: 0.45f, b: 0.789f, a: 1f);

        MyGameObject = GameObject.Find("Cube");
        MyCamera = Camera.main;





}

// Update is called once per frame
void Update()
    {
        
    }
}
