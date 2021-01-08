<?php
include('data/dbh.data.php');
include('inc/session.inc.php');
//include('class/emp.class.php');
include('inc/autoloader.php');

//$userUpdate= new User;
//$userUpdate=$userClass->userEditDetails("Daveru","Lester",34,"Male","Somewhere",$session_empId);
$userDetails=$userClass->userInfo($session_empId);
?>
<!DOCTYPE html>
<html>
<head><title>Home page | Media Bazaar </title>


      <!-- Main CSS-->
        <link href="css/main.css" rel="stylesheet" media="all">
      	<link href="css/styleemplogin.css" rel="stylesheet" type="text/css" >
        </head>
<body>
   <?php
  include('inc/headerctrl.inc.php');
    //include ('inc/headerctrl.inc.php'); ?>
   <div class ="divider"></div>
<table>
  <tr>
  <?php include('inc/homedisplay.php'); ?>

    </tr>




</table>


</body>
</html>
