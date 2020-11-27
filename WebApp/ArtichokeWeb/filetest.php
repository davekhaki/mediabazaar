<?php
include('class/dbh.class.php');
include('inc/session.inc.php');
/*if (!empty($_POST['update']))
{

$firstname=$_POST['firstname'];
$lastname=$_POST['lastname'];
$age=$_POST['age'];
$gender=$_POST['gender'];
$address=$_POST['address'];

$userUpdate=$userClass->userEditDetails($firstname,$lastname,$age,$gender,$address,$session_empId);

}*/
$userDetails=$userClass->userDetails($session_empId);
?>
<html>
<head>
  <title>Update Profile | Media Bazaar</title>
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">


    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">
</head>
<body>
  <?php include ('inc/headerctrl.inc.php');  ?>

  <div class="divider"></div>



    <div class="page-wrapper bg-blue p-t-100 p-b-100 font-robo">
          <div class="wrapper wrapper--w680">
              <div class="card card-1">
                  <div class="card-heading"></div>
                  <div class="card-body">
    <form id ="registration" method="post" action="infoUpdate.php" name="updateInfo">
    <label> FirstName</label>
    <input class="input--style-1"  type="text" name="firstname" value="<?php echo $userDetails->FirstName;?>" readonly>
    <br>
    <br>
    <label> LastName</label>
    <input class="input--style-1" type="text" name="lastname" value="<?php echo $userDetails->LastName;?>"readonly>
    <br>
    <br>
    <label> Age </label>
    <input class="input--style-1" type="text" name="age" value="<?php echo $userDetails->Age;?>"readonly>
    <br>
    <br>
    <label> Gender</label>
    <input  class="input--style-1"type="text" name="gender" value="<?php echo $userDetails->Gender;?>"readonly>
    <br>
    <br>
    <label> Address </label>
    <input class="input--style-1" type="text" name="address" value="<?php echo $userDetails->Adress;?>"readonly>
    <div class="p-t-20">
    <input type="submit"class="btn btn--radius btn--green" name="updateInfo" value="Update"></button>
    </div>
    </form>
    </div>
    </div>
    </div>
    </div>


</body>
</html>
