<?php
	$id = (isset($_GET['empId']) ? $_GET['empId'] : '');
require_once ('process/db1.php');
$sql = "SELECT * from stock";
$sql2 = "SELECT * from stock where Quantity < MinimumQuantity";
$result = mysqli_query($conn1, $sql);
$result2 = mysqli_query($conn1, $sql2);

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

	<div class="divider"></div>
	<div id="divimg">
		<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"> Stock </h2>
    	<table>

			<tr bgcolor="#000">
				<th align = "center">ProductId</th>
				<th align = "center">ProductName</th>
				<th align = "center">ProductPrice</th>
				<th align = "center">Brand</th>
				<th align = "center">Quantity</th>
				<th align = "center">MinimumQuantity</th>


			</tr>



			<?php

				while ($stock = mysqli_fetch_assoc($result)) {
					echo "<tr>";
					echo "<td>".$stock['ProductID']."</td>";

					echo "<td>".$stock['ProductName']."</td>";
					 	echo "<td>".$stock['ProductPrice']."</td>";
							echo "<td>".$stock['Brand']."</td>";

					echo "<td>".$stock['Quantity']."</td>";
						echo "<td>".$stock['MinimumQuantity']."</td>";


				}


			?>

		</table>


			<h2 style="font-family: 'Montserrat', sans-serif; font-size: 25px; text-align: center;"> Depleting Stock </h2>
	    	<table>

				<tr bgcolor="#000">
					<th align = "center">ProductId</th>
					<th align = "center">ProductName</th>
					<th align = "center">ProductPrice</th>
					<th align = "center">Brand</th>
					<th align = "center">Quantity</th>
					<th align = "center">MinimumQuantity</th>


				</tr>



				<?php

					while ($stock = mysqli_fetch_assoc($result2)) {
						echo "<tr>";
						echo "<td>".$stock['ProductID']."</td>";

						echo "<td>".$stock['ProductName']."</td>";
						 	echo "<td>".$stock['ProductPrice']."</td>";
								echo "<td>".$stock['Brand']."</td>";

						echo "<td>".$stock['Quantity']."</td>";
							echo "<td>".$stock['MinimumQuantity']."</td>";


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
