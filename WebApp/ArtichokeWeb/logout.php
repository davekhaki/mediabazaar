<?php
include('class/dbh.class.php');
$session_empId='';
$session_role='';
$_SESSION['empId']='';
$_SESSION['role']='';
session_unset();
session_destroy();
if(empty($session_empId) && empty($_SESSION['empId']) && empty($_SESSION['role']))
{
$url=BASE_URL.'login.php';
header("Location: $url");
//echo "<script>window.location='$url'</script>";
}
