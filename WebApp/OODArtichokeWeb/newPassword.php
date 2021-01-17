<?php
include('data/dbh.data.php');
include('inc/session.inc.php');
include('inc/autoloader.php');
$userClass = new UserLog();

if(!empty($_POST['update'])){

  $password=$_POST['password'];
  $confirmPass=$_POST['confirmPass'];

  if ($password == $confirmPass){
    $userUpdate=$userClass->newPassword($password,$session_empId);
    echo ("<SCRIPT LANGUAGE='JavaScript'>
       window.alert('Succesfully Updated')
       window.location.href='home.php ';
       </SCRIPT>");
  }else{
    echo ("<SCRIPT LANGUAGE='JavaScript'>
       window.alert('Password did not match');
       </SCRIPT>");
  }

}

$userDetails=$userClass->userInfo($session_empId);

?>
<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css/main.css"</head>
<body>
  <div class="divider"></div>

  <div class="page-wrapper bg-blue p-t-100 p-b-100 font-robo">
        <div class="wrapper wrapper--w680">
            <div class="card card-1">
                <div class="card-heading"></div>
                <div class="card-body">
  <form id ="registration" method="post" action="newPassword.php" name="update">
    <div class="input-group">
  <label> Password</label>
  <input class="input--style-1" type="text" name="password" placeholder="Insert New Password">
</div>
<div class="input-group">
  <label> Confirm Password</label>
  <input class="input--style-1" type="text" name="confirmPass" placeholder="Insert Confirm Password">
</div>

  <div class="p-t-20">
  <input type="submit"class="btn btn--radius btn--green" name="update" value="Submit"></button>
  </div>
  </form>
  </div>
  </div>
  </div>
  </div>


</body>
</html>
