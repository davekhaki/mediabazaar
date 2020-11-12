<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * from schedule";

$result = mysqli_query($conn1, $sql);


?>


<html>
<head>
	<title>Manager Panel | Media Bazaar</title>
	<link rel="stylesheet" type="text/css" href="styleemplogin.css">
</head>
<body>

	<header>
		<nav>
			<h1>Media Bazaar</h1>
			<ul id="navli">
				<li><a class="homered" href="aloginwel.php?empId=<?php echo $id;?>">HOME</a></li>
				<li><a class="homeblack" href="viewemp.php?empId=<?php echo $id;?>">View Employee</a></li>
				<li><a class="homeblack" href="aschedule.php?empId=<?php echo $id;?>">Schedule</a></li>
				<li><a class="homeblack" href="amyprofile.php?empId=<?php echo $id;?>">Profile</a></li>
		<!--		<li><a class="homeblack" href="empleave.php">Employee Leave</a></li> -->
				<li><a class="homeblack" href="elogin.html">Log Out</a></li>
			</ul>
		</nav>
	</header>


			<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"> Employee Schedule </h2>
	    	<table>

				<tr bgcolor="#000">
					<th align = "center">Employee</th>
					<th align = "center">TimeofDay</th>
					<th align = "center">Day</th>



				</tr>



				<?php

					while ($stock = mysqli_fetch_assoc($result)) {
						echo "<tr>";

						echo "<td>".$stock['EmployeeID']."</td>";
						 	echo "<td>".$stock['TimeOfDay']."</td>";
								echo "<td>".$stock['Day']."</td>";



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
