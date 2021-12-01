using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BallClicker
{
    public class DestroyBallInputHandler : MonoBehaviour
    {
        private Camera _camera;
        [SerializeField] private Counter counter;

        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            OnClick();
        }

        private void OnClick()
        {
            if(!Input.GetMouseButtonDown(0) || IsTouchOnUI(Input.mousePosition))
                return;
            
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (!Physics.SphereCast(ray, 0.2f, out hit))
                return;

            if (hit.collider.TryGetComponent(out IReward reward))
            {
                counter.AddCount(reward.Reward);
            }
            if (hit.collider.TryGetComponent(out IDestroyable destroyable))
            {
                destroyable.DestroyObject(true);
            }
        }
        
        bool IsTouchOnUI(Vector2 point)
        {
            PointerEventData pointer = new PointerEventData(EventSystem.current);
            pointer.position = point;
            List<RaycastResult> raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointer, raycastResults);

            return raycastResults.Count > 0;
        }

       
    }
}