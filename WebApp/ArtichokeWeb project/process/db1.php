<?php

$servername = "localhost";
$dBUsername = "root";
$dbPassword = "";
$dBName = "dbi434661";

$conn1 = mysqli_connect($servername, $dBUsername, $dbPassword, $dBName);

if(!$conn1){
	echo "Databese Connection Failed";
}

?>
