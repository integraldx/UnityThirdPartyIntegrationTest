using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;

namespace ThirdPartyTest.Main.Editor
{
    public static class BuildPipeline
    {
        private static readonly HashSet<string> s_predefinedKeys = new HashSet<string>
        {
            "-exportPath",
        };
        
        [UsedImplicitly]
        public static void BuildPlayer()
        {
            var parameters = GetCommandLineArguments();
            
            var options = new BuildPlayerOptions
            {
                scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
                target = EditorUserBuildSettings.activeBuildTarget,
                targetGroup = UnityEditor.BuildPipeline.GetBuildTargetGroup(EditorUserBuildSettings.activeBuildTarget),
                locationPathName = parameters["-exportPath"],
            };

            EditorUserBuildSettings.exportAsGoogleAndroidProject = true;
            
            UnityEditor.BuildPipeline.BuildPlayer(options);
        }
        
        private static Dictionary<string, string> GetCommandLineArguments()
        {
            var args = Environment.GetCommandLineArgs();

            var result = new Dictionary<string, string>();

            var currentTargetKey = string.Empty;
            var isValueExpected = false;

            foreach (var argument in args)
            {
                if (isValueExpected)
                {
                    result[currentTargetKey] = argument;
                    isValueExpected = false;
                }
                else if (s_predefinedKeys.Contains(argument))
                {
                    result.Add(argument, string.Empty);

                    currentTargetKey = argument;
                    isValueExpected = true;
                }
                else
                {
                    Debug.Log($"Unknown option {argument}. Skipping.");
                    Console.Error.WriteLine($"Unknown option {argument}. Skipping.");
                }
            }

            return result;
        }
    }
}