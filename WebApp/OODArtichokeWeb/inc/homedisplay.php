<?php
if (!empty($session_role)) {

if ($session_role == "Employee"){
  $schedule= new EmployeeLog();
  $schedule->Schedule($session_empId);

} elseif ($session_role == "Manager") {
  $manager = new ManagerLog();

  $manager->MinStock();

}elseif($session_role=="Admin"){
$admin = new AdminLog();
$admin->viewEmp();
}
  }
?>
