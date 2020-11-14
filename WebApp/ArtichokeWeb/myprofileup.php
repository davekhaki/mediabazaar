<?php

require_once ('process/db1.php');
$sql = "SELECT * FROM `employee` WHERE 1";

//echo "$sql";
$result = mysqli_query($conn1, $sql);
if(isset($_POST['update']))
{

  $id = mysqli_real_escape_string($conn1, $_POST['empId']);

  $gender1 = mysqli_real_escape_string($conn1, $_POST['gender']);
  $adress1 = mysqli_real_escape_string($conn1, $_POST['adress']);



 $result3 = mysqli_query($conn1, "UPDATE employee SET Gender='$gender1',Adress='$adress1' WHERE ID=$id");

 echo ("<SCRIPT LANGUAGE='JavaScript'>
    window.alert('Succesfully Updated')
    window.location.href='myprofile.php?empId=$id  ';
    </SCRIPT>");


}
?>




<?php
  $id = (isset($_GET['empId']) ? $_GET['empId'] : '');
  $sql = "SELECT * from `employee` WHERE ID=$id";
  $result = mysqli_query($conn1, $sql);
  if($result){
  while($res = mysqli_fetch_assoc($result)){
    $firstname = $res['FirstName'];
    $lastname = $res['LastName'];
    $age = $res['Age'];
    $address = $res['Adress'];
    $gender = $res['Gender'];
    $dept= $res['DepartmentName'];
    $hireD = $res['HireDate'];
    $endD = $res['EndDate'];
    $adress = $res['Adress'];
    $salary = $res['Salary'];
  // $salary = $res['salary'];
}
}

?>

<html>
<head>
  <title>Update Profile | Media Bazaar</title>
  <!-- Icons font CSS-->
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">

    <!-- Vendor CSS-->
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="vendor/datepicker/daterangepicker.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">
</head>
<body>
  <header>
    <nav>
      <h1>Update.</h1>
      <ul id="navli">
        <li><a class="homeblack" href="eloginwel.php?empId=<?php echo $id?>">HOME</a></li>
        <li><a class="homered" href="myprofile.php?empId=<?php echo $id?>">My Profile</a></li>
        <!--
        <li><a class="homeblack" href="applyleave.php?id=<?php echo $id?>">Apply Leave</a></li>
      -->
        <li><a class="homeblack" href="elogin.html">Log Out</a></li>
      </ul>
    </nav>
  </header>

  <div class="divider"></div>


    <!-- <form id = "registration" action="edit.php" method="POST"> -->
  <div class="page-wrapper bg-blue p-t-100 p-b-100 font-robo">
        <div class="wrapper wrapper--w680">
            <div class="card card-1">
                <div class="card-heading"></div>
                <div class="card-body">
                    <h2 class="title">Update Employee Info</h2>
                    <form action="myprofileup.php" method="POST">



                        <div class="input-group">
                          <p>Gender</p>
                            <input class="input--style-1" type="text" name="gender" value="<?php echo $gender;?>">
                        </div>




                         <div class="input-group">
                          <p>Address</p>
                            <input class="input--style-1" type="text"  name="adress" value="<?php echo $adress;?>">
                        </div>


                        <input type="hidden" name="empId" id="textField" value="<?php echo $id;?>" required="required"><br><br>
                        <div class="p-t-20">
                            <button class="btn btn--radius btn--green" type="submit" name="update">Submit</button>
                        </div>

                    </form>
                    <br>
                  <!--  <button class="btn btn--radius btn--green" onclick="window.location.href = 'changepassemp.php?id=<?php echo $id?>';">Change Password</button> -->
                </div>
            </div>
        </div>
    </div>


</body>
</html>
