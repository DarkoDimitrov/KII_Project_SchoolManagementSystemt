# wait-for-sqlserver.ps1
$server = "SchoolManagmentSystem"  # Name of the SQL Server container (or the IP address of the SQL Server)
$port = 1433                      # SQL Server port
$timeout = 600                     # Timeout after 10 minutes
$elapsed = 0
$connected = $false

while ($elapsed -lt $timeout) {
    try {
        # Test if SQL Server is responding on the specified port
        $tcpConnection = Test-NetConnection -ComputerName $server -Port $port
        if ($tcpConnection.TcpTestSucceeded) {
            $connected = $true
            break
        }
    } catch {
        Write-Host "Waiting for SQL Server to be ready..."
    }
    Start-Sleep -Seconds 5    # Wait for 5 seconds before checking again
    $elapsed += 5
}

if ($connected) {
    Write-Host "SQL Server is ready, starting the application..."
    exit 0
} else {
    Write-Host "SQL Server did not become available in time."
    exit 1
}