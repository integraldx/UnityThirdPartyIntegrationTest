#/bin/zsh

echo "Hello World!!"

read "?Unity hub install base path (/Applications/Unity/Hub/Editor): " unity_hub_base_path
unity_hub_base_path="${${unity_hub_base_path:-"/Applications/Unity/Hub/Editor"}%/}"
echo $unity_hub_base_path

export UNITY_HUB_BASE_PATH=$unity_hub_base_path
