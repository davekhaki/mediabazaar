<?php
class Admin extends User{
  public function viewEmployee(){
  //  $db = new DB();
  //  $db= connect();
  $stmt = $this->connect()->query("SELECT * FROM employee");
  //$stmt->execute();
  //$stmt->fetchAll();
  echo '<th align = "center">ID</th>';
  echo '<th align = "center">Name</th>';
  echo '<th align = "center">Age</th>';
  echo '<th align = "center">Gender</th>';
  echo '<th align = "center">DepartmentName</th>';
  echo '<th align = "center">HireDate</th>';
  echo '<th align = "center">EndDate</th>';
  echo '<th align = "center">Adress</th>';

  foreach ( $stmt as $employee) {
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
public function passwordGen(){
  $alphabet = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890';
$pass = array(); //remember to declare $pass as an array
$alphaLength = strlen($alphabet) - 1; //put the length -1 in cache
for ($i = 0; $i < 8; $i++) {
   $n = rand(0, $alphaLength);
   $pass[] = $alphabet[$n];
}
return implode($pass); //turn the array into a string
}

public function sendLogin($username,$password){
  $emailTo="sebastianbokkestijn@gmail.com";
  $subject="Login";
  $from = "From: mediabazaarcompany@gmail.com";
  $emailBody = "username =". $username." password = ".$password;
  mail($emailTo,$subject,$emailBody,$from);
}

public function addEmployee($firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary){
  $pass = $this->passwordGen();

  try{
  $stmt = $this->connect()->prepare("INSERT INTO employee(FirstName,LastName,Age,Gender,DepartmentName,HireDate,Adress,Role,Salary) VALUES(?,?,?,?,?,?,?,?,?)");
  $stmt->execute([$firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary]);
  $stmt1= $this->connect()->prepare("SELECT * FROM employee WHERE firstname = ? AND lastname = ?");
  $stmt1->execute([$firstname,$lastname]);
  $data=$stmt1->fetch(PDO::FETCH_OBJ);
  $id = $data->ID;
  $stmt2 = $this->connect()->prepare("INSERT INTO login(empId,username,password) VALUES(?,?,?)");
//$email = $this->sendLogin($firstname."1",$pass);
  $stmt2 ->execute([$id,$firstname."1",$pass]);

}  catch(PDOException $e) {
  echo '{"error":{"text":'. $e->getMessage() .'}}';
  }
}


}
