using Code.Runtime.Extensions;
using Code.Runtime.Gameplay.Logic;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
    [CustomEditor(typeof(CollectablesSpawner))]
    internal sealed class CollectableSpawnerEditor: UnityEditor.Editor
    {
        private const float RandomXRangeThickness = 3;
        
        [DrawGizmo(GizmoType.Active | GizmoType.Selected | GizmoType.NonSelected)]
        public static void RenderCustomGizmo(CollectablesSpawner spawner, GizmoType gizmo)
        {
            Handles.color = Color.yellow;
            Vector3 position = spawner.transform.position;
            Handles.DrawLine(position.SetX(-spawner.RandomDeltaX), position.SetX(spawner.RandomDeltaX), RandomXRangeThickness);
        }
    }
}