#/bin/zsh

echo "====== Set env script for local build of unity project ======"

read "?Unity hub install base path (/Applications/Unity/Hub/Editor): " UNITY_HUB_BASE_PATH
UNITY_HUB_BASE_PATH="${${UNITY_HUB_BASE_PATH:-"/Applications/Unity/Hub/Editor"}%/}"
export UNITY_HUB_BASE_PATH=$UNITY_HUB_BASE_PATH

echo "====== Export complete! ======"