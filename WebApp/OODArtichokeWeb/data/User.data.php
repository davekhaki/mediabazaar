<?php
class User extends DB {

  public function userLogin($username,$password)
  {
  try{
  $stmt = $this->connect()->prepare("SELECT * FROM login l INNER JOIN employee e ON l.empId = e.ID WHERE (username=:username AND password=:password)");
  //$stmt = $this->connect()->prepare("SELECT empId FROM login WHERE (username=:username AND password=:password)");
  $stmt->bindParam("username", $username,PDO::PARAM_STR) ;
  $stmt->bindParam("password", $password,PDO::PARAM_STR) ;
  $stmt->execute();
  $count=$stmt->rowCount();
  $data=$stmt->fetch(PDO::FETCH_OBJ);
//  $what=$data->password;
//$hash = md5($password);

//if($what == $hash){
  if($count){

  $_SESSION['empId']=$data->empId; // Storing user session value
  $_SESSION['role']=$data->Role;
  //return true;
}
  //}
  else
  {
//  return false;
  }
  }
  catch(PDOException $e) {
  echo '{"error":{"text":'. $e->getMessage() .'}}';
  }


}
public function userDetails($empId)
{
try{
//"SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = '$email'";
$stmt = $this->connect()->prepare("SELECT l.empId,e.FirstName,e.LastName,e.Age,e.Gender,e.DepartmentName,e.HireDate,e.EndDate,e.Salary,e.Adress,e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.empId=:empId");
$stmt->bindParam("empId", $empId,PDO::PARAM_INT);
$stmt->execute();
$data = $stmt->fetch(PDO::FETCH_OBJ); //User data
return $data;
}
catch(PDOException $e) {
echo '{"error":{"text":'. $e->getMessage() .'}}';
}
}

public function userEditDetails($firstname,$lastname,$age,$gender,$address,$empId){

  try{
  //"SELECT e.Role FROM employee e INNER JOIN login l ON e.ID = l.empId WHERE l.username = '$email'";
  $stmt = $this->connect()->prepare("UPDATE employee SET FirstName='$firstname',LastName='$lastname',Age='$age',Gender='$gender',Adress='$address' WHERE ID=:empId");
  $stmt->bindParam("empId", $empId,PDO::PARAM_INT);

  $stmt->execute();
  }
  catch(PDOException $e) {
  echo '{"error":{"text":'. $e->getMessage() .'}}';
  }

}
}
