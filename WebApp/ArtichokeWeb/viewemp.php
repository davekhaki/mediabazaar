<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * from `employee`";

//echo "$sql";
$result = mysqli_query($conn1, $sql);

?>



<html>
<head>
	<title>View Employee |  MediaBazaar</title>
	<link rel="stylesheet" type="text/css" href="styleview.css">
</head>
<body>
	<header>
		<nav>
			<h1>  MediaBazaar</h1>
			<ul id="navli">
				<li><a class="homeblack" href="aloginwel.php?empId=<?php echo $id?>">HOME</a></li>

				<li><a class="homered" href="viewemp.php?empId=<?php echo $id?>">View Employee</a></li>
				<li><a class="homeblack" href="amyprofile.php?empId=<?php echo $id?>">Profile</a></li>
			<!--	<li><a class="homeblack" href="empleave.php">Employee Leave</a></li>-->
			<li><a class="homeblack" href="aschedule.php?empId=<?php echo $id;?>">Schedule</a></li>
				<li><a class="homeblack" href="elogin.html">Log Out</a></li>
			</ul>
		</nav>
	</header>

	<div class="divider"></div>

		<table>
			<tr>

				<th align = "center">Emp. ID</th>
				<th align = "center">Name</th>
				<th align = "center">Age</th>
				<th align = "center">Gender</th>
				<th align = "center">DepartmentName</th>
				<th align = "center">HireDate</th>
				<th align = "center">EndDate</th>
				<th align = "center">Adress</th>



				<th align = "center">Options</th>
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


					//echo "<td><a href=\"edit.php?id=$employee[id]\">Edit</a> | <a href=\"delete.php?id=$employee[id]\" onClick=\"return confirm('Are you sure you want to delete?')\">Delete</a></td>";

				}


			?>

		</table>


</body>
</html>
