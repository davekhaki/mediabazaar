<?php
include('data/Admin.data.php');
class AdminLog{

private Admin $admin;

public function __construct(){

$this->admin = new Admin();

}

public function viewEmp(){
$this->admin->viewEmployee();

}
public function EmployeeInfo(){

  $this->admin->viewEmployee();
}

public function addEmployee($firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary,$email){

$this->admin->addEmployee($firstname,$lastname,$age,$gender,$department,$hiredate,$address,$role,$salary,$email);
}

}

 ?>
