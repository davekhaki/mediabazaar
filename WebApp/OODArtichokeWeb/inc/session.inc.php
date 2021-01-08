<?php
if(!empty($_SESSION['empId']))
{
$session_role=$_SESSION['role'];
$session_empId=$_SESSION['empId'];
include('logic/UserLog.logic.php');
$userClass = new UserLog();
}
if(empty($session_empId))
{
$url=BASE_URL.'login.php';
header("Location: $url");
}
?>
