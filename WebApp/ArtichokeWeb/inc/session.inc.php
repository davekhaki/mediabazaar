<?php
if(!empty($_SESSION['empId']))
{
$session_role=$_SESSION['role'];
$session_empId=$_SESSION['empId'];
include('class/User.class.php');
$userClass = new User();
}
if(empty($session_empId))
{
$url=BASE_URL.'login.php';
header("Location: $url");
}
?>
