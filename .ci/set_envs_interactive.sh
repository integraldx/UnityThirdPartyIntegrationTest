#/bin/zsh

echo "====== Set env script for local build of unity project ======"

read "?Unity hub install base path (/Applications/Unity/Hub/Editor): " unity_hub_base_path
unity_hub_base_path="${${unity_hub_base_path:-"/Applications/Unity/Hub/Editor"}%/}"
echo $unity_hub_base_path

export UNITY_HUB_BASE_PATH=$unity_hub_base_path

read "?Unity username: " unity_username
echo $unity_username

export UNITY_USERNAME=$unity_username

read -sr "?Unity password: " unity_password

export UNITY_PASSWORD=$unity_password

read "?Unity serial: " unity_serial
echo $unity_serial

export UNITY_SERIAL=$unity_serial

echo "====== Export complete! ======"