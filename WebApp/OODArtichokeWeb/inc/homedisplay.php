<?php
if (!empty($session_role)) {

if ($session_role == "Employee"){
  $schedule= new EmployeeLog();
  echo "<h1>Your Schedule </h1>" ;
  $schedule->Schedule($session_empId);

} elseif ($session_role == "Manager") {
  $manager = new ManagerLog();

echo "<h1>Low on Stock </h1>" ;
  $manager->MinStock();

}elseif($session_role=="Admin"){
$admin = new AdminLog();
echo "<h1>Employee Info </h1>" ;
$admin->viewEmp();
}
  }
?>
