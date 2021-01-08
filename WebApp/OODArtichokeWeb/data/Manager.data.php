<?php
class Manager extends User{

public function viewEmp(){
  $stmt = $this->connect()->query("SELECT FirstName,LastName,Age,Adress,Gender,DepartmentName,Role,HireDate,EndDate,Salary FROM employee");
$stmt->execute();
$stmt->fetchAll();
echo '<th align = "center">ID</th>';
echo '<th align = "center">Name</th>';
echo '<th align = "center">Age</th>';
echo '<th align = "center">Gender</th>';
echo '<th align = "center">DepartmentName</th>';
echo '<th align = "center">HireDate</th>';
echo '<th align = "center">EndDate</th>';
echo '<th align = "center">Adress</th>';

while ($employee == $stmt) {
echo "<tr>
   <td>".$employee['ID']."</td>
   <td>".$employee['FirstName']." ".$employee['LastName']."</td>
   <td>".$employee['Age']."</td>
   <td>".$employee['Gender']."</td>
   <td>".$employee['DepartmentName']."</td>
  <td>".$employee['HireDate']."</td>
  <td>".$employee['EndDate']."</td>
  <td>".$employee['Adress']."</td></tr>";


}
}
public function viewMinStock(){
  $stmt = $this->connect()->query("SELECT ProductID,ProductName,ProductPrice,Brand,Quantity,MinimumQuantity FROM stock WHERE MinimumQuantity > Quantity");
//$stmt->execute();
//$stmt->fetchAll();
echo '<th align = "center">ProductID</th>';
echo '<th align = "center">ProductName</th>';
echo '<th align = "center">ProductID</th>';
echo '<th align = "center">ProductPrice</th>';
echo '<th align = "center">Brand</th>';
echo '<th align = "center">Quantity</th>';
echo '<th align = "center">MinimumQuantity</th>';
foreach ($stmt as $stock) {
  echo "<tr>
  <td>". $stock['ProductID']."</td>
   <td>".$stock['ProductName']."</td>
   <td>".$stock['ProductID']."</td>
   <td>".$stock['ProductPrice']."</td>
   <td>".$stock['Brand']."</td>
   <td>".$stock['Quantity']."</td>
   <td>".$stock['MinimumQuantity']."</td></tr>";
}

}

public function viewSchedule(){
  $stmt = $this->connect()->query("SELECT e.FirstName as Name,s.TimeOfDay,DATE_FORMAT(s.Day, '%d-%b-%y') AS Day FROM schedule s
  INNER JOIN employee e ON s.EmployeeID = e.ID GROUP BY Day, s.TimeOfDay ORDER BY Day DESC, CASE WHEN TimeOfDay='Morning' THEN '1' WHEN TimeOfDay= 'Afternoon' THEN '2'WHEN TimeOfDay='Evening' THEN '3' END ");
//$stmt->execute();
//$stmt->fetchAll();
echo '<th align = "center">Employee</th>';
echo '<th align = "center">TimeofDay</th>';
echo '<th align = "center">Day</th>';
  foreach ($stmt as $stock) {
    echo "<tr>
     <td>".$stock['Name']."</td>
       <td>".$stock['TimeOfDay']."</td>
         <td>".$stock['Day']."</td></tr>";



  }
}
}
