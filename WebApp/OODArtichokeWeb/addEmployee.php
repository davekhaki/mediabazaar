<?php
include('data/dbh.data.php');
include('inc/session.inc.php');
include('inc/autoloader.php');
$admin = new AdminLog();
if (!empty($_POST['insert']))
{
$firstname=$_POST['firstname'];
$lastname=$_POST['lastname'];
$bday=$_POST['birthdate'];
$gender=$_POST['gender'];
$departmentName=$_POST['departmentName'];
$hireDate=$_POST['hireDate'];
$address=$_POST['address'];
$role=$_POST['role'];
$salary=$_POST['salary'];
$email = $_POST['email'];
$userInsert=$admin->addEmployee($firstname,$lastname,$bday,$gender,$departmentName,$hireDate,$address,$role,$salary,$email);
echo ("<SCRIPT LANGUAGE='JavaScript'>
   window.alert('Succesfully Updated')
   window.location.href='addEmployee.php ';
   </SCRIPT>");
}
$userDetails=$userClass->userInfo($session_empId);
?>
<html>
<head>
  <title>Add Employee | Media Bazaar</title>
    <!-- Font special for pages-->
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i" rel="stylesheet">


    <!-- Main CSS-->
    <link href="css/main.css" rel="stylesheet" media="all">
</head>
<body>
  <?php include('inc/headerctrl.inc.php'); ?>

  <div class="divider"></div>



    <div class="page-wrapper bg-blue p-t-100 p-b-100 font-robo">
          <div class="wrapper wrapper--w680">
              <div class="card card-1">
                  <div class="card-heading"></div>
                  <div class="card-body">
    <form id ="registration" method="post" action="addEmployee.php" name="update">
      <div class="input-group">
    <label> FirstName</label>
    <input class="input--style-1" type="text" name="firstname" placeholder="Insert Firstname" required>
</div>
<div class="input-group">
    <label> LastName</label>
    <input class="input--style-1" type="text" name="lastname" placeholder="Insert Lastname" required>
</div>
<div class="input-group">
    <label> Birthdate </label>
    <input class="input--style-1"type="date" name="birthdate" required>
</div>
<div class="input-group">
    <label> Gender</label>
    <br> <br>
    <select id="gender" name="gender" required>
      <option hidden disabled selected value> -- select an option -- </option>
      <option value="Male">Male</option>
      <option value="Female">Female</option>
    </select>
    </div>
    <div class="input-group">
        <label> DepartmentName</label>
        <br><br>
        <select id="departmentName" name="departmentName" required>
          <option hidden disabled selected value> -- select an option -- </option>
          <option value="Logistic">Logistic</option>
          <option value="Marketing">Marketing</option>
            <option value="Engineering">Engineering</option>
              <option value="Finance">Finance</option>
        </select>
    </div>
    <div class="input-group">
        <label> Hire Date</label>
        <input class="input--style-1" type="date" name="hireDate" required>
    </div>

<div class="input-group">
    <label> Address </label>
    <input class="input--style-1" type="text" name="address" placeholder="Insert address" required>
</div>
<div class="input-group">
    <label> Role </label>
    <br><br>
    <select id="role" name="role" required>
      <option hidden disabled selected value> -- select an option -- </option>
      <option value="Manager">Manager</option>
      <option value="Employee">Employee</option>
        <option value="Admin">Admin</option>
    </select>
</div>
<div class="input-group">
    <label> Salary </label>
    <input class="input--style-1" type="number" name="salary" placeholder="Insert salary here" required>
</div>

<div class="input-group">
    <label> E-mail </label>
    <input class="input--style-1" type="text" name="email" placeholder="Insert Email" required>
</div>
    <div class="p-t-20">
    <input type="submit"class="btn btn--radius btn--green" name="insert" value="Submit"></button>
    </div>
    </form>
    </div>
    </div>
    </div>
    </div>


</body>
</html>
