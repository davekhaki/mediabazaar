<?php

//require_once ('dbh.php');
require_once ('db1.php');

$email = $_POST['mailuid'];
$password = $_POST['pwd'];

/*$sql = "SELECT * from `employee` WHERE email = '$email' AND password = '$password'";
$sqlid = "SELECT id from `employee` WHERE email = '$email' AND password = '$password'";
*/
$sqlrole = "SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = '$email'";

$sql = "SELECT * from login WHERE username = '$email' AND password = '$password'";
$sqlid ="SELECT empId from login WHERE username = '$email' AND password = '$password'";


$result = mysqli_query($conn1, $sql);
$id = mysqli_query($conn1 , $sqlid);
$role = mysqli_query($conn1 , $sqlrole);

$emprole="";
$empid = "";
if(mysqli_num_rows($result) == 1){

	$employee = mysqli_fetch_array($id);
	$employeerole =  mysqli_fetch_array($role);

	$empid = ($employee['empId']);
	$emprole = ($employeerole['Role']);


	//echo ("logged in");
	//echo ("$empid");
	if($emprole == "Manager"){
header("Location: ..//aloginwel.php?empId=$empid");
}
else if($emprole == "Employee"){
	header("Location: ..//eloginwel.php?empId=$empid");
}
else{
		header("Location: ..//aaloginwel.php?empId=$empid");
}
}

else{
	echo ("<SCRIPT LANGUAGE='JavaScript'>
    window.alert('Invalid Email or Password')
    window.location.href='javascript:history.go(-1)';
    </SCRIPT>");
}
?>
