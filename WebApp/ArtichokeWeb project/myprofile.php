<?php

require_once ('process/db1.php');
$sql = "SELECT * FROM `employee` WHERE 1";

//echo "$sql";
$result = mysqli_query($conn1, $sql);


  $id = (isset($_GET['empId']) ? $_GET['empId'] : '');
  $sql = "SELECT * from `employee` WHERE id=$id";
  $sql2 = "SELECT total from `salary` WHERE id = $id";
  $result = mysqli_query($conn1, $sql);
  $result2 = mysqli_query($conn1 , $sql2);


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
  //$pic = $res['pic'];
}
}

?>

<html>
<head>
  <title>My Profile | Media Bazaar</title>
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
      <h1>Media Bazaar.</h1>
      <ul id="navli">
        <li><a class="homeblack" href="eloginwel.php?empId=<?php echo $id?>">HOME</a></li>
        <li><a class="homered" href="myprofile.php?empId=<?php echo $id?>">My Profile</a></li>
        <!--
        <li><a class="homeblack" href="empproject.php?id=<?php echo $id?>">My Projects</a></li>
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
                    <h2 class="title">My Info</h2>
                    <form method="POST" action="myprofileup.php?empId=<?php echo $id;?>" >

<!--
                        <div class="input-group">
                          <img src="process/<?php echo $pic;?>" height = 150px width = 150px>
                        </div>

-->
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                  <p>First Name</p>
                                     <input class="input--style-1" type="text" name="FirstName" value="<?php echo $firstname;?>" readonly >
                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                  <p>Last Name</p>
                                    <input class="input--style-1" type="text" name="LastName" value="<?php echo $lastname;?>" readonly>
                                </div>
                            </div>
                        </div>
                        <div class="row row-space">
                            <div class="col-2">
                                <div class="input-group">
                                  <p>Age</p>
                                    <input class="input--style-1" type="text" name="age" value="<?php echo $age;?>" readonly>

                                </div>
                            </div>
                            <div class="col-2">
                                <div class="input-group">
                                  <p>Gender</p>
                                  <input class="input--style-1" type="text" name="gender" value="<?php echo $gender;?>" readonly>
                                </div>
                            </div>
                        </div>

                        <div class="input-group">
                          <p>Hire Date</p>
                            <input class="input--style-1" type="text" name="hireD" value="<?php echo $hireD;?>" readonly>
                        </div>

                        <div class="input-group">
                          <p>End Date</p>
                            <input class="input--style-1" type="text" name="endD" value="<?php echo $endD;?>" readonly>
                        </div>


                         <div class="input-group">
                          <p>Address</p>
                            <input class="input--style-1" type="text"  name="adress" value="<?php echo $address;?>" readonly>
                        </div>

                        <div class="input-group">
                          <p>Department</p>
                            <input class="input--style-1" type="text" name="dept" value="<?php echo $dept;?>" readonly>
                        </div>

                        <div class="input-group">
                          <p>Salary</p>
                            <input class="input--style-1" type="text" name="salary" value="<?php echo $salary;?>" readonly>
                        </div>

                        <input type="hidden" name="empId" id="textField" value="<?php echo $id;?>" required="required"><br><br>
                        <div class="p-t-20">
                            <button class="btn btn--radius btn--green"  name="send" >Update Info</button>
                        </div>

                    </form>
                </div>
            </div>
        </div>
    </div>


     <!-- Jquery JS-->
    <!-- <script src="vendor/jquery/jquery.min.js"></script>

    <script src="vendor/select2/select2.min.js"></script>
    <script src="vendor/datepicker/moment.min.js"></script>
    <script src="vendor/datepicker/daterangepicker.js"></script>


    <script src="js/global.js"></script> -->
</body>
</html>