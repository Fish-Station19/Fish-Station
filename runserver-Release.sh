#!/bin/bash
set -euo pipefail
cd /home/ubuntu/space-station-14

# Publish Release if missing
if [ ! -f ./bin/publish/Content.Server.dll ]; then
	dotnet publish Content.Server -c Release -o ./bin/publish
fi

# Run the published Release binary
exec dotnet ./bin/publish/Content.Server.dll "$@"
