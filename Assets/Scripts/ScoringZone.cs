using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    // Event Systems helps us to control same operation for two objects in one script.
    // This method is used for handling score system for PlayerPaddle and ComputerPaddle objects.
    // When EventTrigger.TriggerEvent used public the editor shows a section. This section provides to call a method (like button onClickListener()).
    // This script is added to the leftWall and rightWall game objects on the scene(Left Wall - Player Side and Right Wall - Computer Side)
    public EventTrigger.TriggerEvent scoringTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if ball is collided with left or right wall an event data is created which is implied(11th column) by developer on the editor.
        // This event is invoked by UnityEvent class(namespace UnityEngine.Events) instead of MonoBehaviour.
        // In short, this system ensures an event; plus, developer can add methods to these events which they want to do.
        // I used PlayerScores() from GameManager script for RightWall game object, ComputerScores() from GameManager script for LeftWall game object.
        Ball ball = collision.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoringTrigger.Invoke(eventData);
        }
    }
}
