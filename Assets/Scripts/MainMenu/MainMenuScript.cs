using UnityEngine;

//  Script is a component on our eventsystem in the mainmenu scene
public class MainMenuScript : MonoBehaviour
{   
    //  Public reference to our ButtonContainer in scene 
    public GameObject buttonContainer;

    //  Public reference to our LevelSelectionContainer in scene 
    public GameObject levelSelectionContainer; 

    //  Activated when play button is pressed
    public void OnPlay()
    {
        //  Set our button container (play, settings, etc) to not be visible 
        buttonContainer.SetActive(false);

        //  Render our level selection 
        levelSelectionContainer.SetActive(true);
    }

    //  Runs when player presses quit button on main menu 
    public void OnQuit()
    {
        //  https://forum.unity.com/threads/how-to-detect-application-quit-in-editor.344600/#:~:text=Code%20%28CSharp%29%3A%201%20%23if%20UNITY_EDITOR%202%20%2F%2F%20Application.Quit,4%20UnityEditor.EditorApplication.isPlaying%20%3D%20false%3B%205%20%23endif%206%20Application.Quit%28%29%3B
        //  If we are running in a standalone build of the game
        #if UNITY_STANDALONE
            Application.Quit();
        #endif
 
        //  If we are running in the editor
        #if UNITY_EDITOR
            //  Stop playing the scene
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    } 
}
