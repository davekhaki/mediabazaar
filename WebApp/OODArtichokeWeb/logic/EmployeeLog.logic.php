<?php
include('data/Employee.data.php');
class EmployeeLog{


  private Employee $employee;

    public function __construct(){

    $this->employee = new Employee();

    }
  public function Scehdule(){

    $this->employee->viewSchedule();
  }
}

 ?>