<?php
include('class/dbh.class.php');
include('inc/session.inc.php');
include('inc/autoloader.php');
?>
<!DOCTYPE html>
<html>
<head>
  <title> Apply Leave | Media Bazaar</title>
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
    <form id ="registration" method="post" action="infoUpdate.php" name="update">
      <div class="input-group">
    <label> Leave</label>
    <input class="input--style-1" type="text" name="firstname" value="<?php echo $userDetails->FirstName;?>">
</div>
<div class="input-group">
    <label> LastName</label>
    <input class="input--style-1" type="text" name="lastname" value="<?php echo $userDetails->LastName;?>">
</div>

    <br>
</div>
<div class="input-group">
    <label> Address </label>
    <input class="input--style-1" type="text" name="address" value="<?php echo $userDetails->Adress;?>">
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
