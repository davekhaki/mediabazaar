<?php
include ('class/dbh.class.php');
include ('class/User.class.php');
$userClass = new User();

$errorMsgReg='';
$errorMsgLogin='';
/* Login Form */
if (!empty($_POST['loginSubmit']))
{
$username=$_POST['username'];
$password=$_POST['password'];
if(strlen(trim($username))>1 && strlen(trim($password))>1 )
{
$empId=$userClass->userLogin($username,$password);

if($empId)
{
$url=BASE_URL.'home.php';
header("Location: $url"); // Page redirecting to home.php
}
else
{
$errorMsgLogin="Please check login details.";
}
}
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Testing</title>
    <link rel="stylesheet" type="text/css" href="css/stylelogin.css"</head>
<body>
  <div class="divider"></div>

  <div class="loginbox">
<div id="login">
<h3>Login</h3>
<form method="post" action="login.php" name="login">
<label>Username</label>
<input type="text" name="username" placeholder="Type your username" />
<label>Password</label>
<input type="password" name="password" autocomplete="off"/>
<div class="errorMsg"><?php echo $errorMsgLogin; ?></div>
<input type="submit" class="button" name="loginSubmit" value="Login">
</form>
</div>
</div>
</div>
</body>
</html>
