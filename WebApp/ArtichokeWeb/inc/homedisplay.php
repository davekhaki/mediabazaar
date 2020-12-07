<?php
if (!empty($session_role)) {

if ($session_role == "Employee"){
  $schedule= new Employee();
  $schedule->viewSchedule($session_empId);

} elseif ($session_role == "Manager") {
  $manager = new Manager();

  $manager->viewMinStock();

}elseif($session_role=="Admin"){
$admin = new Admin();
$admin->viewEmployee();
}
  }
?>
