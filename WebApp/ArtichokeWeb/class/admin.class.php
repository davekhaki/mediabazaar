<?php
class Admin extends User{
public function addEmployee($firstname,$lastname,$age,$gender,$department,$hiredate,$enddate,$address,$role,$salary){
  $stmt = $this->connect()->prepare("INSERT INTO employee(FirstName,LastName,Age,Gender,DepartmentName,HireDate,EndDate,Adress,Role,Salary) VALUES(?,?,?,?,?,?,?,?,?,?)";
  $stmt->execute([$firstname,$lastname,$age,$gender,$department,$hiredate,$enddate,$address,$role,$salary]);

}

}
public function viewEmployee(){
//  $db = new DB();
//  $db= connect();
  $stmt = $this->connect()->prepare("SELECT FirstName,LastName,Age,Adress,Gender,DepartmentName,Role,HireDate,EndDate,Salary FROM employee";
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
while ($employee = $stmt) {
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
}
