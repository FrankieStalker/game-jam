using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    [SerializeField] public GameObject otherPlayer;
    
    private void OnMouseDown() {
        
        
    }
    
    void OnGUI()
    {
        Event e = Event.current;
        if (e.shift)
        {
            otherPlayer.GetComponent<Animator>().SetBool("walk", false);
            otherPlayer.GetComponent<Animator>().SetBool("grounded", true);
            
            otherPlayer.GetComponent<PlayerController>().enabled = false;
            GetComponent<PlayerController>().enabled = true;

            otherPlayer.GetComponent<PlayerSwitch>().enabled = true;
            this.GetComponent<PlayerSwitch>().enabled = false;


        }
    }
    
}
