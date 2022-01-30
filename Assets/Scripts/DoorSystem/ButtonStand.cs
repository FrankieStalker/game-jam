using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStand : MonoBehaviour
{
    // Start is called before the first frame update
    public bool activated;
    public GameObject player;

    private float threshold = 10.0f;
    private Renderer spriteRenderer;
    private void Awake() {
        activated = false;
        spriteRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {   

            Vector3 playerPos = player.transform.localPosition;
            Vector3 ThisPos = transform.localPosition;
            float dist = Mathf.Sqrt(Mathf.Abs(ThisPos.x*ThisPos.x-playerPos.x*playerPos.x) + Mathf.Abs(ThisPos.y*ThisPos.y-playerPos.y*playerPos.y));
            highlight(dist);
    }
    private void OnGUI() {
        
        
    }

    private void highlight(float dist){


        if(dist<=threshold){
            spriteRenderer.material.color = new Color(0.5f,0.5f,0.5f);
            activated = true;
        }
        else{
            spriteRenderer.material.color = new Color(1.0f,1.0f,1.0f);
            activated = false;
        }
        
    }
}
