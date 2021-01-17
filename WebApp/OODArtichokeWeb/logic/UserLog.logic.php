<?php
include('data/User.data.php');


class UserLog{
private User $user;
  public function __construct(){
  $this->user = new User();
  }

public function Login($username,$password){

  $this->user->userLogin($username,$password);
  return true;

}

public function userInfo($empId){

  return $this->user->userDetails($empId);

}

public function editDetails($firstname,$lastname,$age,$gender,$address,$empId){

  $this->user->userEditDetails($firstname,$lastname,$age,$gender,$address,$empId);
}

public function newPassword($password,$empId){

  $this->user->newPassword($password,$empId);
}

}
 ?>
