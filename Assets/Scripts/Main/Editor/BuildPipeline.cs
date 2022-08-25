using System.Linq;
using JetBrains.Annotations;
using UnityEditor;

namespace ThirdPartyTest.Main.Editor
{
    public static class BuildPipeline
    {
        [UsedImplicitly]
        public static void BuildPlayer()
        {
            var options = new BuildPlayerOptions
            {
                scenes = EditorBuildSettings.scenes.Select(scene => scene.path).ToArray(),
                target = BuildTarget.Android,
                targetGroup = BuildTargetGroup.Android,
                locationPathName = "Build/Gradle"
            };

            EditorUserBuildSettings.exportAsGoogleAndroidProject = true;
            
            UnityEditor.BuildPipeline.BuildPlayer(options);
        }
    }
}