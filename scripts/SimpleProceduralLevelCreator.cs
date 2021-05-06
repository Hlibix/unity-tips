using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEditor.SceneManagement;

public class SimpleProceduralLevelCreator : EditorWindow
{
    [MenuItem("Procedural/Level Creator")]
    public static void ShowWindow()
    {
        GetWindow(typeof(SimpleProceduralLevelCreator));
    }

    private GameObject _prefab;
    private int _width, _height;
    private float _blockSpacing;
    private float _heightMultiplier;
    private int _randomSeed;

    private void OnGUI()
    {
        _width = EditorGUILayout.IntField("Width", _width);
        _height = EditorGUILayout.IntField("Height", _height);
        _heightMultiplier = EditorGUILayout.FloatField("Height Multiplier", _heightMultiplier);
        _blockSpacing = EditorGUILayout.FloatField("Block Spacing", _blockSpacing);
        _randomSeed = EditorGUILayout.IntField("Random Seed", _randomSeed);

        _prefab = (GameObject) EditorGUILayout.ObjectField("Prefab:", _prefab, typeof(GameObject), false);

        if (GUILayout.Button("Spawn prefabs"))
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    var prefabInstance = (GameObject) PrefabUtility.InstantiatePrefab(_prefab);
                    Undo.RegisterCreatedObjectUndo(prefabInstance, "Spawned");

                    prefabInstance.transform.position =
                        new Vector3(i * _blockSpacing,
                            _heightMultiplier * Mathf.PerlinNoise(i / 10f + _randomSeed, j / 10f + _randomSeed),
                            j * _blockSpacing);
                }
            }

            EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        }
    }
}