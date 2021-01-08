<?php
include('data/Manager.data.php');
class ManagerLog{

    private Manager $manager;

    public function __construct(){

    $this->manager = new Manager();

    }
public function employeesInfo(){

$this->manager->viewEmp();
}

public function MinStock(){

$this->manager->viewMinStock();
}

public function Schedule(){

$this->manager->viewSchedule();
}

}
 ?>
