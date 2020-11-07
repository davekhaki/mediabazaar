<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * from employee";
$result = mysqli_query($conn1, $sql);


?>


<html>
<head>
	<title>Manager Panel | Media Bazaar</title>
	<link rel="stylesheet" type="text/css" href="styleemplogin.css">
</head>
<body>

<?php
include ("aaheader.php");
 ?>

	<div class="divider"></div>
	<div id="divimg">
		<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"> Depleting Stock </h2>
			<table>

			<tr bgcolor="#000">
				<th align = "center">Employee</th>
				<th align = "center">TimeofDay</th>
				<th align = "center">Day</th>



			</tr>



			<?php

				while ($stock = mysqli_fetch_assoc($result)) {
					echo "<tr>";

					echo "<td>".$stock['EmployeeId']."</td>";
						echo "<td>".$stock['TimeofDay']."</td>";
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
