<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * FROM `employee` WHERE 1";

//echo "$sql";
$result = mysqli_query($conn1, $sql);
if(isset($_POST['insert']))
{


  $id = mysqli_real_escape_string($conn1, $_POST['empId']);
  $gender1 = mysqli_real_escape_string($conn1, $_POST['gender']);
  $adress1 = mysqli_real_escape_string($conn1, $_POST['adress']);
	$firstname1 = mysqli_real_escape_string($conn1, $_POST['gender']);
	$lastname1 = mysqli_real_escape_string($conn1, $_POST['adress']);
	$age1 = mysqli_real_escape_string($conn1, $_POST['gender']);
  $deparmtment1 = mysqli_real_escape_string($conn1, $_POST['adress']);
	$hiredate1 = mysqli_real_escape_string($conn1, $_POST['gender']);
	$enddate1 = mysqli_real_escape_string($conn1, $_POST['adress']);
	$salary1 = mysqli_real_escape_string($conn1, $_POST['gender']);


function GeneratePassword(){
	$alphabet = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890';
 $pass = array(); //remember to declare $pass as an array
 $alphaLength = strlen($alphabet) - 1; //put the length -1 in cache
 for ($i = 0; $i < 8; $i++) {
		 $n = rand(0, $alphaLength);
		 $pass[] = $alphabet[$n];
 }
 return implode($pass); //turn the array into a string
}
 $result3 = mysqli_query($conn1, "INSERT INTO employee(FirstName,LastName,Age
,Adress
,Gender
,DepartmentName
,HireDate
,EndDate
,Salary) VALUES($gender1
,$adress1
,$firstname1
,$lastname1
,$age1
,$deparmtment1
,$hiredate1
,$enddate1
,$salary1)");
$password = GeneratePassword();
$result4 = mysqli_query("INSERT INTO `login` (`empId`, `username`, `password`) VALUES ('$id', '$firstname11', '$password')";
);


 echo ("<SCRIPT LANGUAGE='JavaScript'>
    window.alert('Succesfully Updated')
    window.location.href='aaloginwel.php.php?empId=$id  ';
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
<?php include('aaheader.php')?>

  <div class="divider"></div>


    <!-- <form id = "registration" action="edit.php" method="POST"> -->
  <div class="page-wrapper bg-blue p-t-100 p-b-100 font-robo">
        <div class="wrapper wrapper--w680">
            <div class="card card-1">
                <div class="card-heading"></div>
                <div class="card-body">
                    <h2 class="title">Update Employee Info</h2>
                    <form id = "registration" action="aamyprofileup.php" method="POST">
											<div class="input-group">
												<p>First Name</p>
													<input class="input--style-1" type="text" name="firstname">
											</div>
											<div class="input-group">
												<p>LastName</p>
													<input class="input--style-1" type="text" name="lastname">
											</div>
											<div class="input-group">
												<p>Age</p>
													<input class="input--style-1" type="text" name="age">
											</div>

                        <div class="input-group">
                          <p>Gender</p>
                            <input class="input--style-1" type="text" name="gender">
                        </div>
												<div class="input-group">
													<p>Department Name</p>
														<input class="input--style-1" type="text" name="department">
												</div>
												<div class="input-group">
													<p>Hire Date</p>
														<input class="input--style-1" type="datepicker" name="hiredate">
														</div>
														<div class="input-group">
															<p>End Date</p>
																<input class="input--style-1" type="datepicker" name="enddate">
												</div>




                         <div class="input-group">
                          <p>Address</p>
                            <input class="input--style-1" type="text"  name="adress">
                        </div>



                        <div class="p-t-20">
                            <button class="btn btn--radius btn--green" type="submit" name="insert">Submit</button>
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
