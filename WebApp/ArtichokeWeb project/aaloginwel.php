<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * from employee";
$result = mysqli_query($conn1, $sql);


?>


<html>
<head>
	<title>Admin Panel | Media Bazaar</title>
	<link rel="stylesheet" type="text/css" href="styleemplogin.css">
</head>
<body>

<?php
include ("aaheader.php");
 ?>

	<div class="divider"></div>
	<div id="divimg">
		<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"> Employees </h2>
			<table>

			<tr bgcolor="#000">
				<th align = "center">Emp. ID</th>
				<th align = "center">Name</th>
				<th align = "center">Age</th>
				<th align = "center">Gender</th>
				<th align = "center">DepartmentName</th>
				<th align = "center">HireDate</th>
				<th align = "center">EndDate</th>
				<th align = "center">Adress</th>



			</tr>



			<?php

				while ($employee = mysqli_fetch_assoc($result)) {
					echo "<tr>";
					echo "<td>".$employee['ID']."</td>";
				//	echo "<td><img src='process/".$employee['pic']."' height = 60px width = 60px></td>";
					echo "<td>".$employee['FirstName']." ".$employee['LastName']."</td>";

					echo "<td>".$employee['Age']."</td>";
					echo "<td>".$employee['Gender']."</td>";
					echo "<td>".$employee['DepartmentName']."</td>";
					echo "<td>".$employee['HireDate']."</td>";
					echo "<td>".$employee['EndDate']."</td>";
					echo "<td>".$employee['Adress']."</td>";



				}
				?>


		</table>



			<br>
			<br>
			<br>
			<br>
				<div class="divider"></div>
		<div class="p-t-20">
		<!--	<button class="btn btn--radius btn--green" type="submit" style="float: right; margin-right: 60px"><a href="reset.php" style="text-decoration: none; color: white"> Reset Points</button> -->
		</div>


	</div>
</body>
</html>
