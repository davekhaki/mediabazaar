<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
	require_once ('process/db1.php');
	 $sql1 = "SELECT * FROM `employee` where id = '$id'";
	 $result1 = mysqli_query($conn1, $sql1);
	 $employeen = mysqli_fetch_array($result1);
	 $empName = ($employeen['FirstName']);

	$sql = "SELECT s.TimeOfDay, s.Day FROM employee e INNER JOIN schedule s ON e.ID = s.EmployeeID WHERE e.ID = '$id'";
	$sql1 = "SELECT `pname`, `duedate` FROM `project` WHERE eid = $id and status = 'Due'";

	$sql2 = "Select * From employee, employee_leave Where employee.id = $id and employee_leave.id = $id order by employee_leave.token";

	$sql3 = "SELECT * FROM `salary` WHERE id = $id";

//echo "$sql";
$result = mysqli_query($conn1, $sql);

?>



<html>
<head>
	<title>Employee Panel | Media Bazaar</title>
	<link rel="stylesheet" type="text/css" href="styleemplogin.css">
	<link href="https://fonts.googleapis.com/css?family=Lobster|Montserrat" rel="stylesheet">
</head>
<body>

	<header>
		<nav>
			<h1>Media Bazaar</h1>
			<ul id="navli">
				<li><a class="homered" href="eloginwel.php?empId=<?php echo $id?>">HOME</a></li>
				<li><a class="homeblack" href="myprofile.php?empId=<?php echo $id?>">My Profile</a></li>
					<!--
				<li><a class="homeblack" href="empproject.php?id=<?php echo $id?>">My Projects</a></li>

		 Do nor display
				<li><a class="homeblack" href="applyleave.php?id=<?php echo $id?>"">Apply Leave</a></li>
			-->
				<li><a class="homeblack" href="elogin.html">Log Out</a></li>
			</ul>
		</nav>
	</header>

	<div class="divider"></div>
	<div id="divimg">
	<div>
		<!-- <h2>Welcome <?php echo "$empName"; ?> </h2> -->

		    	<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"><?php echo "$empName"; ?>  </h2>
    	<table>

			<tr bgcolor="#000">
				<th align = "center">Time of Day.</th>
				<th align = "center">Day</th>


			</tr>



			<?php

				while ($employee = mysqli_fetch_assoc($result)) {
					echo "<tr>";

					echo "<td>".$employee['TimeOfDay']."</td>";

					echo "<td>".$employee['Day']."</td>";
				}


			?>

		</table>


<br>
<br>
<br>
<br>
<br>







	</div>


		</h2>




	</div>
</body>
</html>
