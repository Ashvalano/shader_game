using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTexture : MonoBehaviour
{

    [SerializeField]
    private Texture2D HoverCursorTexture;

    private Cursor CursorTexture;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseOver()
    {
      Cursor.SetCursor(HoverCursorTexture, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
     {
         Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
