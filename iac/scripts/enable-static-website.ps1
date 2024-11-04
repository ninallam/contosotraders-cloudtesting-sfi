$ErrorActionPreference = 'Stop'
$storageAccount = Get-AzStorageAccount -ResourceGroupName $env:ResourceGroupName -AccountName $env:StorageAccountName
Enable-AzStorageStaticWebsite -Context $storageAccount.Context -IndexDocument 'index.html' -ErrorDocument404Path 'index.html'

# Disable SharedKeyAccess, it was enabled to support enabling static website
Set-AzStorageAccount -ResourceGroupName $env:ResourceGroupName -AccountName $env:StorageAccountName -AllowSharedKeyAccess $false