<?php
include('class/dbh.class.php');
include('inc/session.inc.php');
//include('class/emp.class.php');
include('class/Manager.class.php');

$schedule = new Manager();
//$userUpdate= new User;
//$userUpdate=$userClass->userEditDetails("Daveru","Lester",34,"Male","Somewhere",$session_empId);
$userDetails=$userClass->userDetails($session_empId);
?>
<!DOCTYPE html>
<html>
<head><title>Schedule | Media Bazaar </title>


      <!-- Main CSS-->
        <link href="css/main.css" rel="stylesheet" media="all">
      	<link href="css/styleemplogin.css" rel="stylesheet" type="text/css" >
        </head>
<body>

   <?php include ('inc/headerctrl.inc.php'); ?>
   <div class ="divider"></div>
<table>
  <tr>
  <?php $schedule->viewSchedule(); ?>

    </tr>




</table>


</body>
</html>
