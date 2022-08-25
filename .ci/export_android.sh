# /bin/zsh

UNITY_VERSION=$(yq '.m_EditorVersion' < ProjectSettings/ProjectVersion.txt)

UNITY_EXECUTABLE="${UNITY_HUB_BASE_PATH}/${UNITY_VERSION}/Unity.app/Contents/MacOS/Unity"

$UNITY_EXECUTABLE -projectPath ${PWD} -batchmode -quit -buildTarget Android -logFile ${PWD}/unity_build.log -executeMethod ThirdPartyTest.Main.Editor.BuildPipeline.BuildPlayer -exportPath ${PWD}/Build/Gradle