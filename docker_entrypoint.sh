#!/bin/bash
cd /pipeline/source/app/publish
echo "Starting eCommerce Inventory Service"

dotnet StatlerWaldorfCorp.EcommerceInventory.dll --server.urls=http://0.0.0.0:${PORT-"8080"}